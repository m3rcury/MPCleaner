Imports MediaPortal.Configuration

Public Class MPCleanerForm

    Dim _lastrun, _cpu, _time As String
    Dim _cache, _delay As Integer
    Public Shared _clean_now As Boolean = False

    Private Sub MPCleanerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '  get default paths from XML configuration file
        Dim periodicity, when_to_run, checktrigger As Integer
        Dim cache_value, delay_value, checktrigger_value As String

        Using XMLreader As MediaPortal.Profile.Settings = New MediaPortal.Profile.Settings(Config.GetFile(Config.Dir.Config, "MPCleaner.xml"))

            Deletetotrash.Checked = XMLreader.GetValueAsBool("Delete", "trash", True)

            cb_MovingPictures.Checked = XMLreader.GetValueAsBool("Plugins", "MovingPictures", False)
            cb_TVSeries.Checked = XMLreader.GetValueAsBool("Plugins", "TVSeries", False)
            cb_Music.Checked = XMLreader.GetValueAsBool("Plugins", "Music", False)
            cb_Pictures.Checked = XMLreader.GetValueAsBool("Plugins", "Pictures", False)
            cb_YouTubefm.Checked = XMLreader.GetValueAsBool("Plugins", "YouTubefm", False)
            cb_MyEmulator.Checked = XMLreader.GetValueAsBool("Plugins", "MyEmulator", False)
            _cache = XMLreader.GetValueAsInt("Plugins", "cache", 1)
            cache_value = XMLreader.GetValueAsString("Plugins", "cache value", "months")

            _delay = XMLreader.GetValueAsInt("Scheduler", "delay", 0)
            delay_value = XMLreader.GetValueAsString("Scheduler", "delay value", "seconds")
            periodicity = XMLreader.GetValueAsInt("Scheduler", "periodicity", 0)
            when_to_run = XMLreader.GetValueAsInt("Scheduler", "when to run", 0)
            _cpu = XMLreader.GetValueAsString("Scheduler", "CPU utilisation", 30)
            _time = XMLreader.GetValueAsString("Scheduler", "run at", 0)
            checktrigger = XMLreader.GetValueAsInt("Scheduler", "check trigger", 1)
            checktrigger_value = XMLreader.GetValueAsString("Scheduler", "check trigger value", "minutes")
            cb_pause.Checked = XMLreader.GetValueAsString("Scheduler", "pause while playing", False)
            _lastrun = XMLreader.GetValueAsString("Scheduler", "lastrun", Nothing)

        End Using

        Deletepermanent.Checked = Not Deletetotrash.Checked

        ' set up screen fields

        nud_cache.Value = _cache
        cb_cache.Text = cache_value
        nud_delay.Value = _delay
        cb_delay.Text = delay_value
        mtb_cpu.Text = _cpu
        mtb_time.Text = _time
        nud_checktrigger.Value = checktrigger
        cb_checktrigger.Text = checktrigger_value

        rb_always.Checked = (periodicity = 0)
        rb_daily.Checked = (periodicity = 1)
        rb_weekly.Checked = (periodicity = 2)
        rb_monthly.Checked = (periodicity = 3)
        rb_startup.Checked = (when_to_run = 0)
        rb_cpu.Checked = (when_to_run = 1)
        rb_time.Checked = (when_to_run = 2)

    End Sub

    Private Sub setSettings()

        Dim periodicity, when_to_run As Integer

        If rb_always.Checked Then
            periodicity = 0
        ElseIf rb_daily.Checked Then
            periodicity = 1
        ElseIf rb_weekly.Checked Then
            periodicity = 2
        ElseIf rb_monthly.Checked Then
            periodicity = 3
        End If

        If rb_startup.Checked Then
            when_to_run = 0
        ElseIf rb_cpu.Checked Then
            when_to_run = 1
        ElseIf rb_time.Checked Then
            when_to_run = 2
        End If

        Using XMLwriter As MediaPortal.Profile.Settings = New MediaPortal.Profile.Settings(Config.GetFile(Config.Dir.Config, "MPCleaner.xml"))

            XMLwriter.SetValueAsBool("Delete", "trash", Deletetotrash.Checked)

            XMLwriter.SetValueAsBool("Plugins", "MovingPictures", cb_MovingPictures.Checked)
            XMLwriter.SetValueAsBool("Plugins", "TVSeries", cb_TVSeries.Checked)
            XMLwriter.SetValueAsBool("Plugins", "Music", cb_Music.Checked)
            XMLwriter.SetValueAsBool("Plugins", "Pictures", cb_Pictures.Checked)
            XMLwriter.SetValueAsBool("Plugins", "YouTubefm", cb_YouTubefm.Checked)
            XMLwriter.SetValueAsBool("Plugins", "MyEmulator", cb_MyEmulator.Checked)
            XMLwriter.SetValue("Plugins", "cache", nud_cache.Value)
            XMLwriter.SetValue("Plugins", "cache value", cb_cache.SelectedItem.ToString)

            XMLwriter.SetValue("Scheduler", "delay", nud_delay.Value)
            XMLwriter.SetValue("Scheduler", "delay value", cb_delay.SelectedItem.ToString)
            XMLwriter.SetValue("Scheduler", "periodicity", periodicity)
            XMLwriter.SetValue("Scheduler", "when to run", when_to_run)
            XMLwriter.SetValue("Scheduler", "CPU utilisation", mtb_cpu.Text)
            XMLwriter.SetValue("Scheduler", "run at", mtb_time.Text)
            XMLwriter.SetValue("Scheduler", "check trigger", nud_checktrigger.Value)
            XMLwriter.SetValue("Scheduler", "check trigger value", cb_checktrigger.SelectedItem.ToString)
            XMLwriter.SetValue("Scheduler", "pause while playing", cb_pause.Checked)

            If _lastrun = Nothing Then XMLwriter.SetValue("Scheduler", "lastrun", Now)

        End Using

        MediaPortal.Profile.Settings.SaveCache()

    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles Save.Click

        setSettings()

        MsgBox("Configuration Saved", MsgBoxStyle.Information, "MPCleaner")

        Return

    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click

        Return

    End Sub

    Private Sub b_clean_Click(sender As System.Object, e As System.EventArgs) Handles b_clean.Click

        Me.Cursor = Windows.Forms.Cursors.WaitCursor

        setSettings()

        _clean_now = True

        Dim mpc As New MPCleanerProcess
        mpc.MPCleanerProcess()

        _clean_now = False

        Me.Cursor = Windows.Forms.Cursors.Default

    End Sub

    Private Sub rb_always_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_always.CheckedChanged

        rb_startup.Enabled = Not rb_always.Checked
        nud_delay.Enabled = Not rb_always.Checked
        cb_delay.Enabled = Not rb_always.Checked
        rb_time.Enabled = Not rb_always.Checked
        mtb_time.Enabled = Not rb_always.Checked

        If rb_always.Checked Then
            rb_startup.Checked = False
            rb_cpu.Checked = True
            rb_time.Checked = False
        End If

    End Sub

    Private Sub rb_startup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_startup.CheckedChanged

        nud_checktrigger.Enabled = Not rb_startup.Checked
        cb_checktrigger.Enabled = Not rb_startup.Checked

    End Sub

End Class