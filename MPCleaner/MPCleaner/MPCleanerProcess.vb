Imports MediaPortal.Configuration
Imports MediaPortal.GUI.Library
Imports MediaPortal.Util

Imports MyFilmsPlugin.DataBase
Imports MyFilmsPlugin.MyFilms.Utils

Imports Microsoft.VisualBasic.FileIO

Imports System.IO
Imports System.Data.SQLite
Imports System.Threading

Public Class MPCleanerProcess

    Dim _cache As Integer
    Dim checkplayer As Integer = 60
    Dim _database, _thumbs, delete, cache_value As String
    Dim movingpictures, tvseries, music, pictures, videos, youtubefm, trash, pause As Boolean

    Public Function CPU_Usage_Percent() As String

        Dim cpu As PerformanceCounter = New PerformanceCounter("Processor", "% Processor Time", "_Total")

        Dim dummy As Long

        dummy = cpu.NextValue()
        System.Threading.Thread.Sleep(1000)

        Return cpu.NextValue().ToString("#0") & "%"

    End Function

    Private Sub wait(ByVal seconds As Long, Optional ByVal verbose As Boolean = True)

        If verbose Then Log.Info("MPCleaner: process plugin sleeping " & seconds.ToString & " seconds.....")

        System.Threading.Thread.Sleep(seconds * 1000)

    End Sub

    Private Sub CheckPlayerplaying(ByVal seconds As Long)
        If pause Then
            Do While MediaPortal.Player.g_Player.Playing
                wait(seconds, False)
            Loop
        End If
    End Sub

    Public Sub MPCleanerProcess()

        Dim file As String = Config.GetFile(Config.Dir.Config, "MPCleaner.xml")

        If Not IO.File.Exists(file) Then Return

        ' set default delete to trash
        trash = True

        Log.Info("MPCleaner: process plugin initialisation.")

        '  get default paths from XML configuration file

        Dim periodicity, when_to_run, _delay, _checktrigger As Integer
        Dim delay_value, checktrigger_value, lastrun, _cpu, _time, current_cpu, current_time As String
        Dim run, _already_executed As Boolean

        ' set startup value for first run
        _already_executed = False

        Using XMLreader As MediaPortal.Profile.Settings = New MediaPortal.Profile.Settings(Config.GetFile(Config.Dir.Base, "MediaPortalDirs.xml"))

            _database = XMLreader.GetValueAsString("Path", "Database", Config.GetFolder(Config.Dir.Database))
            _thumbs = XMLreader.GetValueAsString("Path", "Thumbs", Config.GetFolder(Config.Dir.Thumbs))

        End Using

        Using XMLreader As MediaPortal.Profile.Settings = New MediaPortal.Profile.Settings(file)

            movingpictures = XMLreader.GetValueAsBool("Plugins", "MovingPictures", False)
            tvseries = XMLreader.GetValueAsBool("Plugins", "TVSeries", False)
            music = XMLreader.GetValueAsBool("Plugins", "Music", False)
            pictures = XMLreader.GetValueAsBool("Plugins", "Pictures", False)
            videos = XMLreader.GetValueAsBool("Plugins", "Videos", False)
            youtubefm = XMLreader.GetValueAsBool("Plugins", "YouTubefm", False)
            _cache = XMLreader.GetValueAsInt("Plugins", "cache", 1)
            cache_value = XMLreader.GetValueAsString("Plugins", "cache value", "months")

            _delay = XMLreader.GetValueAsInt("Scheduler", "delay", 0)
            delay_value = XMLreader.GetValueAsString("Scheduler", "delay value", "seconds")
            periodicity = XMLreader.GetValueAsInt("Scheduler", "periodicity", 0)
            when_to_run = XMLreader.GetValueAsInt("Scheduler", "when to run", 0)
            _cpu = XMLreader.GetValueAsString("Scheduler", "CPU utilisation", 30)
            _time = XMLreader.GetValueAsString("Scheduler", "run at", 0)
            _checktrigger = XMLreader.GetValueAsInt("Scheduler", "check trigger", 1)
            checktrigger_value = XMLreader.GetValueAsString("Scheduler", "check trigger value", "minutes")
            pause = XMLreader.GetValueAsString("Scheduler", "pause while playing", False)

            lastrun = XMLreader.GetValueAsString("Scheduler", "lastrun", Now.ToString)

            trash = XMLreader.GetValueAsBool("Delete", "trash", True)

        End Using

        ' calculate actual delay in seconds

        If delay_value = "minutes" Then
            _delay = _delay * 60
        ElseIf delay_value = "hours" Then
            _delay = _delay * 3600
        End If

        ' calculate trigger polling time in seconds

        If checktrigger_value = "minutes" Then
            _checktrigger = _checktrigger * 60
        ElseIf delay_value = "hours" Then
            _checktrigger = _checktrigger * 3600
        End If

        Do

            Log.Info("MPCleaner: process plugin last run on " & lastrun)

            ' check periodicity to see it plugin should run

            If periodicity = 0 Then
                Log.Info("MPCleaner: process plugin configured to run always.")
                run = True
            ElseIf periodicity = 1 Then
                Log.Info("MPCleaner: process plugin configured to run daily.")
                run = (DateDiff(DateInterval.Day, CDate(lastrun), Now) > 0)
            ElseIf periodicity = 2 Then
                Log.Info("MPCleaner: process plugin configured to run weekly.")
                run = (DateDiff(DateInterval.Weekday, CDate(lastrun), Now) > 0)
            ElseIf periodicity = 3 Then
                Log.Info("MPCleaner: process plugin configured to run monthly.")
                run = (DateDiff(DateInterval.Month, CDate(lastrun), Now) > 0)
            Else
                run = False
            End If

            ' check when plugin should run

            If when_to_run = 0 Then
                Log.Info("MPCleaner: process plugin configured to run at MediaPortal startup.")
                run = run And Not _already_executed
            ElseIf when_to_run = 1 Then
                current_cpu = CPU_Usage_Percent()
                Log.Info("MPCleaner: process plugin configured to run when CPU utilisation is less than " & _cpu & ". CPU currently at " & current_cpu)
                run = run And (CULng(Replace(current_cpu, "%", Nothing)) <= CULng(Replace(_cpu, "%", Nothing)))
            ElseIf when_to_run = 2 Then
                current_time = Format(TimeOfDay, "HH:mm")
                Log.Info("MPCleaner: process plugin configured to run at " & _time & ". Current time is " & current_time)
                run = run And (current_time >= _time)
            End If

            If run Or MPCleanerForm._clean_now Then

                ' check that both paths end with a "\"

                If InStrRev(_database, "\") <> Len(_database) Then _database = Trim(_database) & "\"
                If InStrRev(_thumbs, "\") <> Len(_thumbs) Then _thumbs = Trim(_thumbs) & "\"

                ' set the delete mode value
                If trash Then delete = "to trash" Else delete = "permanently"

                If _delay > 0 And when_to_run = 0 Then
                    wait(_delay)
                Else
                    Log.Info("MPCleaner: process plugin starting execution immediately.")
                End If

                ' define cleaner threads
                Dim cleanerThread(8) As Thread

                cleanerThread(0) = New Thread(AddressOf Process_MovingPictures)
                cleanerThread(1) = New Thread(AddressOf Process_DVDArt1)
                cleanerThread(2) = New Thread(AddressOf Process_Persons)
                cleanerThread(3) = New Thread(AddressOf Process_TVSeries)
                cleanerThread(4) = New Thread(AddressOf Process_DVDArt2)
                cleanerThread(5) = New Thread(AddressOf Process_YouTubefm)
                cleanerThread(6) = New Thread(AddressOf Process_Music)
                cleanerThread(7) = New Thread(AddressOf Process_Pictures)
                cleanerThread(8) = New Thread(AddressOf Process_Videos)

                ' call the cleaning processes
                If movingpictures Then cleanerThread(0).Start()
                If movingpictures Then cleanerThread(1).Start()
                If movingpictures Then cleanerThread(2).Start()
                If tvseries Then cleanerThread(3).Start()
                If tvseries Then cleanerThread(4).Start()
                If youtubefm Then cleanerThread(5).Start()
                If music Then cleanerThread(6).Start()
                If pictures Then cleanerThread(7).Start()
                If videos Then cleanerThread(8).Start()

                Dim active As Boolean = True

                Do While active
                    active = False
                    For x As Integer = 0 To UBound(cleanerThread)
                        If cleanerThread(x).IsAlive Then
                            active = True
                            wait(5, False)
                        End If
                    Next
                Loop

                ' update xml with last run date

                Using XMLwriter As MediaPortal.Profile.Settings = New MediaPortal.Profile.Settings(Config.GetFile(Config.Dir.Config, "MPCleaner.xml"))

                    lastrun = Now.ToString

                    XMLwriter.SetValue("Scheduler", "lastrun", lastrun)

                End Using

            Else
                Log.Info("MPCleaner: process plugin execution skipped.")
            End If

            Log.Info("MPCleaner: process plugin complete.")

            If MPCleanerForm._clean_now Then Exit Do

            _already_executed = True

            If when_to_run <> 0 Then
                ' pause for next iteration
                wait(_checktrigger)
            Else
                Exit Do
            End If

        Loop

        Return

    End Sub

    Private Sub delete_file_by_date(ByVal newpath As String, ByVal text As String)

        If IO.Directory.Exists(newpath) Then

            On Error Resume Next

            Log.Info("MPCleaner: processing " & newpath & " - start")

            Dim fileattrib As IO.FileAttributes
            Dim counter As Integer
            Dim date_interval As DateInterval

            If cache_value = "days" Then
                date_interval = DateInterval.Day
            ElseIf cache_value = "weeks" Then
                date_interval = DateInterval.Weekday
            Else
                date_interval = DateInterval.Month
            End If

            For Each filePath As String In IO.Directory.GetFiles(newpath)

                CheckPlayerplaying(checkplayer)

                fileattrib = IO.File.GetAttributes(filePath)

                If DateDiff(date_interval, IO.File.GetLastAccessTime(filePath), Now) >= _cache And fileattrib <> FileAttribute.System Then

                    counter += 1

                    If trash Then
                        FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                    Else
                        FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
                    End If

                End If
            Next

            Log.Info("MPCleaner: processing " & newpath & " - complete. Images deleted " & delete & ": " & counter)

        End If

    End Sub

    Private Sub delete_file(ByVal newpath As String, ByRef List As String, ByVal match As String, ByVal text As String, Optional ByVal diradd As String = Nothing)

        If IO.Directory.Exists(newpath) Then

            On Error Resume Next

            Log.Info("MPCleaner: processing " & newpath & " - start")

            Dim filename As String
            Dim fileattrib As IO.FileAttributes
            Dim counter As Integer

            For Each filePath As String In IO.Directory.GetFiles(newpath)

                CheckPlayerplaying(checkplayer)

                fileattrib = IO.File.GetAttributes(filePath)

                If match = "filename" Then
                    filename = diradd & IO.Path.GetFileName(filePath)
                ElseIf match = "filenamenosuffix" Then
                    filename = diradd & IO.Path.GetFileName(filePath)
                    filename = Left(filename, InStr(filename, ".") - 1)
                Else
                    filename = filePath
                End If

                If InStr(List.ToLower, filename.ToLower) = 0 And fileattrib <> FileAttribute.System Then

                    counter += 1

                    If trash Then
                        FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                    Else
                        FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
                    End If

                End If

            Next

            Log.Info("MPCleaner: processing " & newpath & " - complete. Images deleted " & delete & ": " & counter)

        End If

    End Sub

    Private Sub DeleteFanart_dir(ByVal newpath As String, ByRef List As String, ByVal text As String)

        If IO.Directory.Exists(newpath) Then

            On Error Resume Next

            Log.Info("MPCleaner: processing " & newpath & " - start")

            Dim counter As Integer

            For Each dirpath As String In IO.Directory.GetDirectories(newpath)

                CheckPlayerplaying(checkplayer)

                Dim dirname As String = IO.Path.GetFileName(dirpath)

                If InStr(List.ToLower, dirname.ToLower) = 0 Then

                    counter += 1

                    If trash Then
                        FileSystem.DeleteDirectory(dirpath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                    Else
                        FileSystem.DeleteDirectory(dirpath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
                    End If
                End If

            Next

            Log.Info("MPCleaner: processing " & newpath & " - complete. Folders deleted " & delete & ": " & counter)

        End If

    End Sub

    Private Sub DeleteFanart_subdir(ByVal newpath As String, ByRef List As String, ByVal text As String)

        If IO.Directory.Exists(newpath) Then

            For Each dirpath As String In IO.Directory.GetDirectories(newpath)

                Dim dirname As String = IO.Path.GetFileName(dirpath)

                delete_file(dirpath & "\Episodes", List, "filename", text, dirname & "\Episodes\")

            Next

        End If

    End Sub

    Private Sub Delete_thumbs(ByRef thumbnails As Array, ByVal objtype As String)

        On Error Resume Next

        Log.Info("MPCleaner: processing " & objtype & " - start")

        Dim path As String = _thumbs & objtype
        Dim counter As Integer

        For Each file As String In IO.Directory.GetFiles(path, "*.*", IO.SearchOption.AllDirectories)

            CheckPlayerplaying(checkplayer)

            If Array.IndexOf(thumbnails, file) = -1 Then

                counter += 1

                If trash Then
                    FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                Else
                    FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
                End If

            End If

        Next

        Log.Info("MPCleaner: processing " & objtype & " - complete. Thumbs deleted " & delete & ": " & counter)

    End Sub

    Public Shared Function loadMovingPicturesPersons(ByVal database As String) As SortedList

        If Not IO.File.Exists(database & "\movingpictures.db3") Then Return Nothing

        Dim personlist As New SortedList
        Dim persons As Array
        Dim x As Integer = -1
        Dim y As Integer
        Dim SQLconnect As New SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        SQLconnect.ConnectionString = "Data Source=" & database & "\movingpictures.db3;Read Only=True;"

        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "SELECT directors||writers||actors, imdb_id FROM movie_info WHERE directors||writers||actors IS NOT NULL AND imdb_id IS NOT NULL"
        SQLreader = SQLcommand.ExecuteReader()

        While SQLreader.Read()

            If Trim(SQLreader(0)) <> "" Then

                persons = Split(Mid(SQLreader(0), 2, Len(SQLreader(0)) - 2).Replace("||", "|"), "|")

                For y = 0 To UBound(persons)

                    If Not String.IsNullOrEmpty(Trim(persons(y))) Then
                        If Not personlist.ContainsKey(persons(y)) Then personlist.Add(persons(y), SQLreader(1))
                    End If

                Next

            End If

        End While

        SQLconnect.Close()

        Return personlist

    End Function

    Public Shared Function loadMyFilmsPersons(ByVal personlist As SortedList) As SortedList

        If Not IO.File.Exists(Config.GetFile(Config.Dir.Config, "MyFilms.xml")) Then Return personlist

        Dim x As Integer = -1
        Dim y As Integer
        Dim persons As Array
        Dim dataExport As AntMovieCatalog = New AntMovieCatalog()

        If personlist IsNot Nothing Then x = personlist.Count - 1

        Using XmlConfig As XmlSettings = New XmlSettings(Config.GetFile(Config.Dir.Config, "MyFilms.xml"))

            Dim MesFilms_nb_config As Integer = XmlConfig.ReadXmlConfig("MyFilms", "MyFilms", "NbConfig", -1)
            Dim mf_configs As ArrayList = New ArrayList()

            For i As Integer = 0 To MesFilms_nb_config
                mf_configs.Add(XmlConfig.ReadXmlConfig("MyFilms", "MyFilms", "ConfigName" & i.ToString, String.Empty))
            Next

            For Each mf_config As String In mf_configs

                Dim Catalog As String = XmlConfig.ReadXmlConfig("MyFilms", mf_config, "AntCatalog", String.Empty)

                If IO.File.Exists(Catalog) Then

                    dataExport.ReadXml(Catalog)

                    Dim mfmovies As DataRow() = dataExport.Tables("Movie").Select

                    For Each movie As DataRow In mfmovies

                        If Not IsDBNull(movie("Persons")) Then

                            If Not movie(("Persons")) = String.Empty Then

                                persons = Split(movie(("Persons")), ",")

                                For y = 0 To UBound(persons)

                                    If Not String.IsNullOrEmpty(Trim(persons(y))) Then
                                        If Not personlist.ContainsKey(persons(y)) Then personlist.Add(persons(y), movie("IMDB_id"))
                                    End If

                                Next

                            End If
                        End If
                    Next

                End If

            Next

        End Using

        Return personlist

    End Function

    Private Sub get_DVDArt_Settings(ByRef movie_path As String, ByRef person_path As String, ByRef series_path As String, ByRef music_path As String)

        Using XMLreader As MediaPortal.Profile.Settings = New MediaPortal.Profile.Settings(Config.GetFile(Config.Dir.Config, "DVDArt_Plugin.xml"))

            movie_path = XMLreader.GetValueAsString("Scraper Movies", "path", _thumbs & "\MovingPictures")
            person_path = XMLreader.GetValueAsString("Scraper Movies", "person path", _thumbs & "\Actors")
            series_path = XMLreader.GetValueAsString("Scraper Series", "path", _thumbs & "\TVSeries")
            music_path = XMLreader.GetValueAsString("Scraper Music", "path", _thumbs & "\Music")

        End Using

    End Sub

    Private Sub Process_DVDArt1()

        ' check if DVDArt is used

        If Not IO.File.Exists(_database & "dvdart.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing DVDArt (MovingPictures) - start.")

        Dim newpath, List(1) As String
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader
        Dim moviepath As String = Nothing
        Dim personpath As String = Nothing
        Dim seriespath As String = Nothing
        Dim musicpath As String = Nothing
        Dim match As String = Nothing

        ' populate used DVDArt

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "dvdart.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT imdb_id FROM processed_movies WHERE imdb_id <> ''"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                List(0) &= SQLreader(0) & "|"

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing DVDArt (MovingPictures) - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then List(0) = ""

        ' check DVDArt on disk which are not in DB

        get_DVDArt_Settings(moviepath, personpath, seriespath, musicpath)

        newpath = moviepath & "\DVDArt\FullSize"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        newpath = moviepath & "\DVDArt\Thumbs"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        ' check ClearArt on disk which are not in DB

        newpath = moviepath & "\ClearArt\FullSize"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        newpath = moviepath & "\ClearArt\Thumbs"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        ' check ClearLogo on disk which are not in DB

        newpath = moviepath & "\ClearLogo\FullSize"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        newpath = moviepath & "\ClearLogo\Thumbs"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        Log.Info("MPCleaner: processing DVDArt (MovingPictures) - complete.")

    End Sub

    Private Sub Process_DVDArt2()

        ' check if DVDArt is used

        If Not IO.File.Exists(_database & "dvdart.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing DVDArt (TVSeries) - start.")

        Dim newpath, List(1) As String
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader
        Dim moviepath As String = Nothing
        Dim personpath As String = Nothing
        Dim seriespath As String = Nothing
        Dim musicpath As String = Nothing
        Dim match As String = Nothing

        ' populate used DVDArt

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "dvdart.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT thetvdb_id FROM processed_series WHERE thetvdb_id <> ''"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                List(0) &= SQLreader(0) & "|"

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing DVDArt (TVSeries) - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then List(0) = ""

        ' check ClearArt on disk which are not in DB

        get_DVDArt_Settings(moviepath, personpath, seriespath, musicpath)

        newpath = seriespath & "\ClearArt\FullSize"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        newpath = seriespath & "\ClearArt\Thumbs"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        ' check ClearLogo on disk which are not in DB

        newpath = seriespath & "\ClearLogo\FullSize"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        newpath = seriespath & "\ClearLogo\Thumbs"
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

        Log.Info("MPCleaner: processing DVDArt (TVSeries) - complete.")

    End Sub

    Private Sub Process_Persons()

        If Not IO.File.Exists(_database & "\movingpictures.db3") And Not IO.File.Exists(Config.GetFile(Config.Dir.Config, "MyFilms.xml")) Then Exit Sub

        Dim mypersons As SortedList = loadMovingPicturesPersons(_database)

        Try
            mypersons = loadMyFilmsPersons(mypersons)
        Catch ex As Exception
        End Try

        ' process loaded persons

        Dim newpath, List(1) As String
        Dim moviepath As String = Nothing
        Dim personpath As String = Nothing
        Dim seriespath As String = Nothing
        Dim musicpath As String = Nothing
        Dim match As String = Nothing

        get_DVDArt_Settings(moviepath, personpath, seriespath, musicpath)

        For i As Integer = 0 To mypersons.Count - 1
            List(0) &= mypersons.GetKey(i) & "|"
        Next

        newpath = personpath
        match = Right(newpath, Len(newpath) - Len(_thumbs))
        delete_file(newpath, List(0), "filenamenosuffix", match)

    End Sub

    Private Sub Process_MovingPictures()

        Dim newpath, List(1) As String

        ' populate used Fanart and Thumbs

        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        If Not IO.File.Exists(_database & "movingpictures.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing movingpictures - start.")

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "movingpictures.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT alternatecovers, backdropfullpath FROM movie_info"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                If Len(SQLreader(0)) > 0 Then List(0) &= SQLreader(0)
                If Len(SQLreader(1)) > 0 Then List(1) &= SQLreader(1) & "|"

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing movingpictures - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then List(0) = ""
        If List(1) = Nothing Then List(1) = ""

        ' check Fanart and Thumbs on disk which are not in DB

        newpath = _thumbs & "MovingPictures\Covers\FullSize"
        delete_file(newpath, List(0), "full", "MovingPictures\Covers\FullSize")

        newpath = _thumbs & "MovingPictures\Covers\Thumbs"
        delete_file(newpath, List(0), "filename", "MovingPictures\Covers\Thumbs")

        newpath = _thumbs & "MovingPictures\Backdrops\FullSize"
        delete_file(newpath, List(1), "full", "MovingPictures\Backdrops\FullSize")

        Log.Info("MPCleaner: processing movingpictures - complete.")

    End Sub

    Private Sub Process_TVSeries()

        Dim newpath, List(1) As String

        ' populate used Banners and Posters

        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        If Not IO.File.Exists(_database & "TVSeriesDatabase4.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing tvseries - start.")

        ' delete fanart records for removed TVSeries

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "TVSeriesDatabase4.db3;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "DELETE FROM Fanart WHERE seriesID NOT IN (SELECT ID FROM online_series)"
            SQLcommand.ExecuteNonQuery()
            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing tvseries (3) - failed with error when deleting extra fanart records: " & ex.Message)
        End Try

        SQLconnect.ConnectionString = "Data Source=" & _database & "TVSeriesDatabase4.db3;Read Only=True;"

        ' check Series on disk which are not in DB
        Try
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT BannerFileNames FROM online_series WHERE BannerFileNames <> ''"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                List(0) &= Left(SQLreader(0), InStr(2, SQLreader(0), "\") - 1) & "|"

            End While

            SQLreader.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing tvseries (1) - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then
            List(0) = ""
        Else
            List(0) = List(0).Replace("/", "\")
        End If

        newpath = _thumbs & "MPTVSeriesBanners"
        DeleteFanart_dir(newpath, List(0), "MPTVSeriesBanners")

        ' check Episodes on disk which are not in DB

        Try
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT thumbFilename FROM online_episodes WHERE thumbFilename <> ''"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                List(0) &= SQLreader(0) & "|"

            End While

            SQLreader.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing tvseries (2) - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then List(0) = ""

        newpath = _thumbs & "MPTVSeriesBanners"
        DeleteFanart_subdir(newpath, List(0), "MPTVSeriesBanners")

        ' check Fanart and Thumbs on disk which are not in DB

        Array.Clear(List, 0, 2)

        Try
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT BannerPath, ThumbnailPath FROM Fanart"
            SQLreader = SQLcommand.ExecuteReader()

            While SQLreader.Read()

                If Len(SQLreader(0)) > 0 Then List(0) &= SQLreader(0) & "|"
                If Len(SQLreader(1)) > 0 Then List(1) &= SQLreader(1) & "|"

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing tvseries (3) - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then
            List(0) = ""
        Else
            List(0) = List(0).Replace("/", "\")
        End If

        If List(1) = Nothing Then
            List(1) = ""
        Else
            List(1) = List(1).Replace("/", "\")
        End If

        ' check Fanart and Thumbs on disk which are not in DB

        newpath = _thumbs & "Fan Art\fanart\original"
        delete_file(newpath, List(0), "filename", "Fan Art\original")

        newpath = _thumbs & "Fan Art\_cache\fanart\original"
        delete_file(newpath, List(1), "filename", "Fan Art\cache")

        Log.Info("MPCleaner: processing tvseries - complete.")

    End Sub

    Private Sub Process_YouTubefm()

        Dim newpath, List(1) As String

        ' populate Artist names

        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        If Not IO.File.Exists(_database & "YouTubeFm_Data_V01.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing youtube.fm - start.")

        ' check Artist images on disk which are not in DB

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database + "YouTubeFm_Data_V01.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT artist_name FROM artists"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                List(0) &= SQLreader(0) & "|"

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing youtube.fm - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then
            List(0) = ""
        End If

        newpath = _thumbs & "Youtube.Fm\Fanart"
        delete_file(newpath, List(0), "filenamenosuffix", "Youtube.Fm\Fanart")

        newpath = _thumbs & "Youtube.Fm\Cache"
        delete_file_by_date(newpath, "Youtube.Fm\Cache")

        Log.Info("MPCleaner: processing youtube.fm - complete.")

    End Sub

    Private Sub Process_Music()

        Dim newpath, List(1) As String

        ' populate Artist names

        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        If Not IO.File.Exists(_database & "FanartHandler.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing music - start.")

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "FanartHandler.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT FullPath FROM Image WHERE Category LIKE '%usic%'"
            SQLreader = SQLcommand.ExecuteReader()

            Array.Clear(List, 0, 2)

            While SQLreader.Read()

                List(0) &= SQLreader(0) & "|"

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing music - failed with error: " & ex.Message)
            Exit Sub
        End Try

        If List(0) = Nothing Then
            List(0) = ""
        End If

        newpath = _thumbs & "Music\Artists"
        delete_file(newpath, List(0), "full", "Music\Artists")

        newpath = _thumbs & "Music\Albums"
        delete_file(newpath, List(0), "full", "Music\Albums")

        Log.Info("MPCleaner: processing music - complete.")

    End Sub

    Private Sub Process_Pictures()

        Dim thumbnailImage() As String = Nothing
        Dim x As Integer = -1

        ' populate picture list

        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        If Not IO.File.Exists(_database & "PictureDatabase.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing pictures - start.")

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "PictureDatabase.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT strFile FROM picture"
            SQLreader = SQLcommand.ExecuteReader()

            While SQLreader.Read()

                If IO.File.Exists(SQLreader(0)) Then
                    x += 1
                    ReDim Preserve thumbnailImage(x + 1)
                    thumbnailImage(x) = Utils.GetPicturesThumbPathname(SQLreader(0))
                    x += 1
                    thumbnailImage(x) = Utils.GetPicturesLargeThumbPathname(SQLreader(0))
                End If

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing pictures - failed with error: " & ex.Message)
            Exit Sub
        End Try

        Delete_thumbs(thumbnailImage, "Pictures")

        Log.Info("MPCleaner: processing pictures - complete.")

    End Sub

    Private Sub Process_Videos()

        Dim thumbnailImage() As String = Nothing
        Dim x As Integer = -1

        ' populate picture list

        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        Dim SQLreader As SQLiteDataReader

        If Not IO.File.Exists(_database & "VideoDatabaseV5.db3") Then
            Exit Sub
        End If

        Log.Info("MPCleaner: processing videos - start.")

        Try
            SQLconnect.ConnectionString = "Data Source=" & _database & "VideoDatabaseV5.db3;Read Only=True;"
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT strPath||strFilename FROM files f, path p WHERE f.idPath = p.idPath"
            SQLreader = SQLcommand.ExecuteReader()

            While SQLreader.Read()

                If IO.File.Exists(SQLreader(0)) Then
                    x += 1
                    ReDim Preserve thumbnailImage(x + 1)
                    thumbnailImage(x) = Utils.GetVideosThumbPathname(SQLreader(0))
                    x += 1
                    thumbnailImage(x) = Utils.GetVideosLargeThumbPathname(SQLreader(0))
                End If

            End While

            SQLconnect.Close()
        Catch ex As Exception
            Log.Info("MPCleaner: processing videos - failed with error: " & ex.Message)
            Exit Sub
        End Try

        Delete_thumbs(thumbnailImage, "Videos")

        Log.Info("MPCleaner: processing videos - complete.")

    End Sub

End Class
