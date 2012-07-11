<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MPCleanerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MPCleanerForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Deletepermanent = New System.Windows.Forms.RadioButton()
        Me.Deletetotrash = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Paths = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Browse2 = New System.Windows.Forms.Button()
        Me.Browse1 = New System.Windows.Forms.Button()
        Me.tb_thumbpath = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tb_dbpath = New System.Windows.Forms.TextBox()
        Me.Plugins = New System.Windows.Forms.TabPage()
        Me.cb_cache = New System.Windows.Forms.ComboBox()
        Me.nud_cache = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_MyEmulator = New System.Windows.Forms.CheckBox()
        Me.cb_YouTubefm = New System.Windows.Forms.CheckBox()
        Me.cb_Music = New System.Windows.Forms.CheckBox()
        Me.cb_TVSeries = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cb_MovingPictures = New System.Windows.Forms.CheckBox()
        Me.Scheduler = New System.Windows.Forms.TabPage()
        Me.cb_checktrigger = New System.Windows.Forms.ComboBox()
        Me.nud_checktrigger = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_delay = New System.Windows.Forms.ComboBox()
        Me.nud_delay = New System.Windows.Forms.NumericUpDown()
        Me.mtb_cpu = New System.Windows.Forms.MaskedTextBox()
        Me.rb_cpu = New System.Windows.Forms.RadioButton()
        Me.mtb_time = New System.Windows.Forms.MaskedTextBox()
        Me.rb_time = New System.Windows.Forms.RadioButton()
        Me.rb_startup = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_always = New System.Windows.Forms.RadioButton()
        Me.rb_monthly = New System.Windows.Forms.RadioButton()
        Me.rb_weekly = New System.Windows.Forms.RadioButton()
        Me.rb_daily = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Paths.SuspendLayout()
        Me.Plugins.SuspendLayout()
        CType(Me.nud_cache, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scheduler.SuspendLayout()
        CType(Me.nud_checktrigger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nud_delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(0, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Copyright © 2012, m3rcury"
        '
        'Save
        '
        Me.Save.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Save.Location = New System.Drawing.Point(240, 390)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 44
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(321, 390)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 57
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Deletepermanent
        '
        Me.Deletepermanent.AutoSize = True
        Me.Deletepermanent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletepermanent.Location = New System.Drawing.Point(226, 19)
        Me.Deletepermanent.Name = "Deletepermanent"
        Me.Deletepermanent.Size = New System.Drawing.Size(154, 22)
        Me.Deletepermanent.TabIndex = 59
        Me.Deletepermanent.Text = "Delete Permanently"
        Me.Deletepermanent.UseVisualStyleBackColor = True
        '
        'Deletetotrash
        '
        Me.Deletetotrash.AutoSize = True
        Me.Deletetotrash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletetotrash.Location = New System.Drawing.Point(10, 19)
        Me.Deletetotrash.Name = "Deletetotrash"
        Me.Deletetotrash.Size = New System.Drawing.Size(127, 22)
        Me.Deletetotrash.TabIndex = 60
        Me.Deletetotrash.Text = "Delete to Trash"
        Me.Deletetotrash.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Deletetotrash)
        Me.GroupBox1.Controls.Add(Me.Deletepermanent)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 52)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Paths)
        Me.TabControl1.Controls.Add(Me.Plugins)
        Me.TabControl1.Controls.Add(Me.Scheduler)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(393, 311)
        Me.TabControl1.TabIndex = 62
        '
        'Paths
        '
        Me.Paths.BackColor = System.Drawing.Color.Transparent
        Me.Paths.Controls.Add(Me.TextBox4)
        Me.Paths.Controls.Add(Me.Browse2)
        Me.Paths.Controls.Add(Me.Browse1)
        Me.Paths.Controls.Add(Me.tb_thumbpath)
        Me.Paths.Controls.Add(Me.TextBox3)
        Me.Paths.Controls.Add(Me.tb_dbpath)
        Me.Paths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paths.Location = New System.Drawing.Point(4, 25)
        Me.Paths.Name = "Paths"
        Me.Paths.Padding = New System.Windows.Forms.Padding(3)
        Me.Paths.Size = New System.Drawing.Size(385, 282)
        Me.Paths.TabIndex = 0
        Me.Paths.Text = "Paths"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(6, 73)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(321, 19)
        Me.TextBox4.TabIndex = 57
        Me.TextBox4.Text = "Choose Thumbs folder"
        '
        'Browse2
        '
        Me.Browse2.Location = New System.Drawing.Point(314, 97)
        Me.Browse2.Name = "Browse2"
        Me.Browse2.Size = New System.Drawing.Size(62, 23)
        Me.Browse2.TabIndex = 55
        Me.Browse2.Text = "Browse"
        Me.Browse2.UseVisualStyleBackColor = True
        '
        'Browse1
        '
        Me.Browse1.Location = New System.Drawing.Point(314, 40)
        Me.Browse1.Name = "Browse1"
        Me.Browse1.Size = New System.Drawing.Size(62, 23)
        Me.Browse1.TabIndex = 52
        Me.Browse1.Text = "Browse"
        Me.Browse1.UseVisualStyleBackColor = True
        '
        'tb_thumbpath
        '
        Me.tb_thumbpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_thumbpath.Location = New System.Drawing.Point(6, 98)
        Me.tb_thumbpath.Name = "tb_thumbpath"
        Me.tb_thumbpath.Size = New System.Drawing.Size(303, 20)
        Me.tb_thumbpath.TabIndex = 56
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 16)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(321, 19)
        Me.TextBox3.TabIndex = 54
        Me.TextBox3.Text = "Choose database folder"
        '
        'tb_dbpath
        '
        Me.tb_dbpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_dbpath.Location = New System.Drawing.Point(6, 41)
        Me.tb_dbpath.Name = "tb_dbpath"
        Me.tb_dbpath.Size = New System.Drawing.Size(303, 20)
        Me.tb_dbpath.TabIndex = 53
        '
        'Plugins
        '
        Me.Plugins.BackColor = System.Drawing.Color.Transparent
        Me.Plugins.Controls.Add(Me.cb_cache)
        Me.Plugins.Controls.Add(Me.nud_cache)
        Me.Plugins.Controls.Add(Me.Label3)
        Me.Plugins.Controls.Add(Me.cb_MyEmulator)
        Me.Plugins.Controls.Add(Me.cb_YouTubefm)
        Me.Plugins.Controls.Add(Me.cb_Music)
        Me.Plugins.Controls.Add(Me.cb_TVSeries)
        Me.Plugins.Controls.Add(Me.TextBox1)
        Me.Plugins.Controls.Add(Me.cb_MovingPictures)
        Me.Plugins.Location = New System.Drawing.Point(4, 25)
        Me.Plugins.Name = "Plugins"
        Me.Plugins.Padding = New System.Windows.Forms.Padding(3)
        Me.Plugins.Size = New System.Drawing.Size(385, 282)
        Me.Plugins.TabIndex = 1
        Me.Plugins.Text = "Plugins"
        '
        'cb_cache
        '
        Me.cb_cache.FormattingEnabled = True
        Me.cb_cache.Items.AddRange(New Object() {"days", "weeks", "months"})
        Me.cb_cache.Location = New System.Drawing.Point(313, 252)
        Me.cb_cache.Name = "cb_cache"
        Me.cb_cache.Size = New System.Drawing.Size(66, 24)
        Me.cb_cache.TabIndex = 70
        Me.cb_cache.Text = "days"
        '
        'nud_cache
        '
        Me.nud_cache.Location = New System.Drawing.Point(274, 252)
        Me.nud_cache.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nud_cache.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_cache.Name = "nud_cache"
        Me.nud_cache.Size = New System.Drawing.Size(36, 22)
        Me.nud_cache.TabIndex = 69
        Me.nud_cache.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_cache.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Delete images  from cache folders older than"
        '
        'cb_MyEmulator
        '
        Me.cb_MyEmulator.AutoSize = True
        Me.cb_MyEmulator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_MyEmulator.Location = New System.Drawing.Point(232, 77)
        Me.cb_MyEmulator.Name = "cb_MyEmulator"
        Me.cb_MyEmulator.Size = New System.Drawing.Size(111, 22)
        Me.cb_MyEmulator.TabIndex = 67
        Me.cb_MyEmulator.Text = "My Emulator"
        Me.cb_MyEmulator.UseVisualStyleBackColor = True
        Me.cb_MyEmulator.Visible = False
        '
        'cb_YouTubefm
        '
        Me.cb_YouTubefm.AutoSize = True
        Me.cb_YouTubefm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_YouTubefm.Location = New System.Drawing.Point(16, 105)
        Me.cb_YouTubefm.Name = "cb_YouTubefm"
        Me.cb_YouTubefm.Size = New System.Drawing.Size(107, 22)
        Me.cb_YouTubefm.TabIndex = 66
        Me.cb_YouTubefm.Text = "YouTube.fm"
        Me.cb_YouTubefm.UseVisualStyleBackColor = True
        '
        'cb_Music
        '
        Me.cb_Music.AutoSize = True
        Me.cb_Music.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Music.Location = New System.Drawing.Point(232, 49)
        Me.cb_Music.Name = "cb_Music"
        Me.cb_Music.Size = New System.Drawing.Size(67, 22)
        Me.cb_Music.TabIndex = 65
        Me.cb_Music.Text = "Music"
        Me.cb_Music.UseVisualStyleBackColor = True
        '
        'cb_TVSeries
        '
        Me.cb_TVSeries.AutoSize = True
        Me.cb_TVSeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_TVSeries.Location = New System.Drawing.Point(15, 77)
        Me.cb_TVSeries.Name = "cb_TVSeries"
        Me.cb_TVSeries.Size = New System.Drawing.Size(87, 22)
        Me.cb_TVSeries.TabIndex = 64
        Me.cb_TVSeries.Text = "TVSeries"
        Me.cb_TVSeries.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(16, 15)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 19)
        Me.TextBox1.TabIndex = 63
        Me.TextBox1.Text = "Apply Cleanup to the following Plugins"
        '
        'cb_MovingPictures
        '
        Me.cb_MovingPictures.AutoSize = True
        Me.cb_MovingPictures.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_MovingPictures.Location = New System.Drawing.Point(16, 49)
        Me.cb_MovingPictures.Name = "cb_MovingPictures"
        Me.cb_MovingPictures.Size = New System.Drawing.Size(129, 22)
        Me.cb_MovingPictures.TabIndex = 62
        Me.cb_MovingPictures.Text = "MovingPictures"
        Me.cb_MovingPictures.UseVisualStyleBackColor = True
        '
        'Scheduler
        '
        Me.Scheduler.BackColor = System.Drawing.Color.Transparent
        Me.Scheduler.Controls.Add(Me.cb_checktrigger)
        Me.Scheduler.Controls.Add(Me.nud_checktrigger)
        Me.Scheduler.Controls.Add(Me.Label2)
        Me.Scheduler.Controls.Add(Me.GroupBox3)
        Me.Scheduler.Controls.Add(Me.GroupBox2)
        Me.Scheduler.Location = New System.Drawing.Point(4, 25)
        Me.Scheduler.Name = "Scheduler"
        Me.Scheduler.Padding = New System.Windows.Forms.Padding(3)
        Me.Scheduler.Size = New System.Drawing.Size(385, 282)
        Me.Scheduler.TabIndex = 2
        Me.Scheduler.Text = "Scheduler"
        '
        'cb_checktrigger
        '
        Me.cb_checktrigger.FormattingEnabled = True
        Me.cb_checktrigger.Items.AddRange(New Object() {"seconds", "minutes", "hours"})
        Me.cb_checktrigger.Location = New System.Drawing.Point(171, 252)
        Me.cb_checktrigger.Name = "cb_checktrigger"
        Me.cb_checktrigger.Size = New System.Drawing.Size(80, 24)
        Me.cb_checktrigger.TabIndex = 10
        Me.cb_checktrigger.Text = "minutes"
        '
        'nud_checktrigger
        '
        Me.nud_checktrigger.Location = New System.Drawing.Point(131, 253)
        Me.nud_checktrigger.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nud_checktrigger.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_checktrigger.Name = "nud_checktrigger"
        Me.nud_checktrigger.Size = New System.Drawing.Size(36, 22)
        Me.nud_checktrigger.TabIndex = 8
        Me.nud_checktrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_checktrigger.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Check trigger every "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_delay)
        Me.GroupBox3.Controls.Add(Me.nud_delay)
        Me.GroupBox3.Controls.Add(Me.mtb_cpu)
        Me.GroupBox3.Controls.Add(Me.rb_cpu)
        Me.GroupBox3.Controls.Add(Me.mtb_time)
        Me.GroupBox3.Controls.Add(Me.rb_time)
        Me.GroupBox3.Controls.Add(Me.rb_startup)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 103)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Trigger"
        '
        'cb_delay
        '
        Me.cb_delay.FormattingEnabled = True
        Me.cb_delay.Items.AddRange(New Object() {"seconds", "minutes", "hours"})
        Me.cb_delay.Location = New System.Drawing.Point(266, 20)
        Me.cb_delay.Name = "cb_delay"
        Me.cb_delay.Size = New System.Drawing.Size(80, 24)
        Me.cb_delay.TabIndex = 12
        Me.cb_delay.Text = "seconds"
        '
        'nud_delay
        '
        Me.nud_delay.Location = New System.Drawing.Point(226, 21)
        Me.nud_delay.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nud_delay.Name = "nud_delay"
        Me.nud_delay.Size = New System.Drawing.Size(36, 22)
        Me.nud_delay.TabIndex = 11
        Me.nud_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtb_cpu
        '
        Me.mtb_cpu.Location = New System.Drawing.Point(176, 45)
        Me.mtb_cpu.Mask = "00%"
        Me.mtb_cpu.Name = "mtb_cpu"
        Me.mtb_cpu.Size = New System.Drawing.Size(34, 22)
        Me.mtb_cpu.TabIndex = 11
        Me.mtb_cpu.Text = "30"
        Me.mtb_cpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rb_cpu
        '
        Me.rb_cpu.AutoSize = True
        Me.rb_cpu.Location = New System.Drawing.Point(11, 47)
        Me.rb_cpu.Name = "rb_cpu"
        Me.rb_cpu.Size = New System.Drawing.Size(168, 20)
        Me.rb_cpu.TabIndex = 8
        Me.rb_cpu.TabStop = True
        Me.rb_cpu.Text = "when CPU usage below"
        Me.rb_cpu.UseVisualStyleBackColor = True
        '
        'mtb_time
        '
        Me.mtb_time.Location = New System.Drawing.Point(44, 72)
        Me.mtb_time.Mask = "00:00"
        Me.mtb_time.Name = "mtb_time"
        Me.mtb_time.Size = New System.Drawing.Size(39, 22)
        Me.mtb_time.TabIndex = 7
        Me.mtb_time.Text = "0000"
        Me.mtb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtb_time.ValidatingType = GetType(Date)
        '
        'rb_time
        '
        Me.rb_time.AutoSize = True
        Me.rb_time.Location = New System.Drawing.Point(11, 73)
        Me.rb_time.Name = "rb_time"
        Me.rb_time.Size = New System.Drawing.Size(37, 20)
        Me.rb_time.TabIndex = 1
        Me.rb_time.TabStop = True
        Me.rb_time.Text = "at"
        Me.rb_time.UseVisualStyleBackColor = True
        '
        'rb_startup
        '
        Me.rb_startup.AutoSize = True
        Me.rb_startup.Location = New System.Drawing.Point(11, 21)
        Me.rb_startup.Name = "rb_startup"
        Me.rb_startup.Size = New System.Drawing.Size(220, 20)
        Me.rb_startup.TabIndex = 0
        Me.rb_startup.TabStop = True
        Me.rb_startup.Text = "on MediaPortal Startup, delay by"
        Me.rb_startup.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_always)
        Me.GroupBox2.Controls.Add(Me.rb_monthly)
        Me.GroupBox2.Controls.Add(Me.rb_weekly)
        Me.GroupBox2.Controls.Add(Me.rb_daily)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 134)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodicity"
        '
        'rb_always
        '
        Me.rb_always.AutoSize = True
        Me.rb_always.Location = New System.Drawing.Point(11, 105)
        Me.rb_always.Name = "rb_always"
        Me.rb_always.Size = New System.Drawing.Size(69, 20)
        Me.rb_always.TabIndex = 3
        Me.rb_always.TabStop = True
        Me.rb_always.Text = "Always"
        Me.rb_always.UseVisualStyleBackColor = True
        '
        'rb_monthly
        '
        Me.rb_monthly.AutoSize = True
        Me.rb_monthly.Location = New System.Drawing.Point(11, 78)
        Me.rb_monthly.Name = "rb_monthly"
        Me.rb_monthly.Size = New System.Drawing.Size(72, 20)
        Me.rb_monthly.TabIndex = 2
        Me.rb_monthly.TabStop = True
        Me.rb_monthly.Text = "Monthly"
        Me.rb_monthly.UseVisualStyleBackColor = True
        '
        'rb_weekly
        '
        Me.rb_weekly.AutoSize = True
        Me.rb_weekly.Location = New System.Drawing.Point(11, 51)
        Me.rb_weekly.Name = "rb_weekly"
        Me.rb_weekly.Size = New System.Drawing.Size(72, 20)
        Me.rb_weekly.TabIndex = 1
        Me.rb_weekly.TabStop = True
        Me.rb_weekly.Text = "Weekly"
        Me.rb_weekly.UseVisualStyleBackColor = True
        '
        'rb_daily
        '
        Me.rb_daily.AutoSize = True
        Me.rb_daily.Location = New System.Drawing.Point(11, 24)
        Me.rb_daily.Name = "rb_daily"
        Me.rb_daily.Size = New System.Drawing.Size(57, 20)
        Me.rb_daily.TabIndex = 0
        Me.rb_daily.TabStop = True
        Me.rb_daily.Text = "Daily"
        Me.rb_daily.UseVisualStyleBackColor = True
        '
        'MPCleanerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 421)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MPCleanerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MPCleaner v1.1.0.5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Paths.ResumeLayout(False)
        Me.Paths.PerformLayout()
        Me.Plugins.ResumeLayout(False)
        Me.Plugins.PerformLayout()
        CType(Me.nud_cache, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scheduler.ResumeLayout(False)
        Me.Scheduler.PerformLayout()
        CType(Me.nud_checktrigger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nud_delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Deletepermanent As System.Windows.Forms.RadioButton
    Friend WithEvents Deletetotrash As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Plugins As System.Windows.Forms.TabPage
    Friend WithEvents cb_MyEmulator As System.Windows.Forms.CheckBox
    Friend WithEvents cb_YouTubefm As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Music As System.Windows.Forms.CheckBox
    Friend WithEvents cb_TVSeries As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cb_MovingPictures As System.Windows.Forms.CheckBox
    Friend WithEvents Paths As System.Windows.Forms.TabPage
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Browse2 As System.Windows.Forms.Button
    Friend WithEvents Browse1 As System.Windows.Forms.Button
    Friend WithEvents tb_thumbpath As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_dbpath As System.Windows.Forms.TextBox
    Friend WithEvents Scheduler As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_always As System.Windows.Forms.RadioButton
    Friend WithEvents rb_monthly As System.Windows.Forms.RadioButton
    Friend WithEvents rb_weekly As System.Windows.Forms.RadioButton
    Friend WithEvents rb_daily As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_cpu As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rb_cpu As System.Windows.Forms.RadioButton
    Friend WithEvents mtb_time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rb_time As System.Windows.Forms.RadioButton
    Friend WithEvents rb_startup As System.Windows.Forms.RadioButton
    Friend WithEvents nud_checktrigger As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_checktrigger As System.Windows.Forms.ComboBox
    Friend WithEvents cb_delay As System.Windows.Forms.ComboBox
    Friend WithEvents nud_delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_cache As System.Windows.Forms.ComboBox
    Friend WithEvents nud_cache As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
