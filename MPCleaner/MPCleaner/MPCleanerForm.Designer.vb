﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Plugins = New System.Windows.Forms.TabPage()
        Me.cb_Videos = New System.Windows.Forms.CheckBox()
        Me.cb_Pictures = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Deletetotrash = New System.Windows.Forms.RadioButton()
        Me.Deletepermanent = New System.Windows.Forms.RadioButton()
        Me.cb_cache = New System.Windows.Forms.ComboBox()
        Me.nud_cache = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_YouTubefm = New System.Windows.Forms.CheckBox()
        Me.cb_Music = New System.Windows.Forms.CheckBox()
        Me.cb_TVSeries = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cb_Movies = New System.Windows.Forms.CheckBox()
        Me.Scheduler = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cb_checktrigger = New System.Windows.Forms.ComboBox()
        Me.nud_checktrigger = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_pause = New System.Windows.Forms.CheckBox()
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
        Me.b_clean = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Plugins.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_cache, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scheduler.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nud_checktrigger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(0, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Copyright © 2013, m3rcury"
        '
        'Save
        '
        Me.Save.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Save.Location = New System.Drawing.Point(240, 333)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 44
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(321, 333)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 57
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Plugins)
        Me.TabControl1.Controls.Add(Me.Scheduler)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(393, 311)
        Me.TabControl1.TabIndex = 62
        '
        'Plugins
        '
        Me.Plugins.BackColor = System.Drawing.Color.Transparent
        Me.Plugins.Controls.Add(Me.cb_Videos)
        Me.Plugins.Controls.Add(Me.cb_Pictures)
        Me.Plugins.Controls.Add(Me.GroupBox1)
        Me.Plugins.Controls.Add(Me.cb_cache)
        Me.Plugins.Controls.Add(Me.nud_cache)
        Me.Plugins.Controls.Add(Me.Label3)
        Me.Plugins.Controls.Add(Me.cb_YouTubefm)
        Me.Plugins.Controls.Add(Me.cb_Music)
        Me.Plugins.Controls.Add(Me.cb_TVSeries)
        Me.Plugins.Controls.Add(Me.TextBox1)
        Me.Plugins.Controls.Add(Me.cb_Movies)
        Me.Plugins.Location = New System.Drawing.Point(4, 25)
        Me.Plugins.Name = "Plugins"
        Me.Plugins.Padding = New System.Windows.Forms.Padding(3)
        Me.Plugins.Size = New System.Drawing.Size(385, 282)
        Me.Plugins.TabIndex = 1
        Me.Plugins.Text = "Plugins"
        '
        'cb_Videos
        '
        Me.cb_Videos.AutoSize = True
        Me.cb_Videos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Videos.Location = New System.Drawing.Point(232, 105)
        Me.cb_Videos.Name = "cb_Videos"
        Me.cb_Videos.Size = New System.Drawing.Size(72, 22)
        Me.cb_Videos.TabIndex = 73
        Me.cb_Videos.Text = "Videos"
        Me.cb_Videos.UseVisualStyleBackColor = True
        '
        'cb_Pictures
        '
        Me.cb_Pictures.AutoSize = True
        Me.cb_Pictures.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Pictures.Location = New System.Drawing.Point(232, 77)
        Me.cb_Pictures.Name = "cb_Pictures"
        Me.cb_Pictures.Size = New System.Drawing.Size(81, 22)
        Me.cb_Pictures.TabIndex = 72
        Me.cb_Pictures.Text = "Pictures"
        Me.cb_Pictures.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Deletetotrash)
        Me.GroupBox1.Controls.Add(Me.Deletepermanent)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 52)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        '
        'Deletetotrash
        '
        Me.Deletetotrash.AutoSize = True
        Me.Deletetotrash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletetotrash.Location = New System.Drawing.Point(23, 19)
        Me.Deletetotrash.Name = "Deletetotrash"
        Me.Deletetotrash.Size = New System.Drawing.Size(127, 22)
        Me.Deletetotrash.TabIndex = 60
        Me.Deletetotrash.Text = "Delete to Trash"
        Me.Deletetotrash.UseVisualStyleBackColor = True
        '
        'Deletepermanent
        '
        Me.Deletepermanent.AutoSize = True
        Me.Deletepermanent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletepermanent.Location = New System.Drawing.Point(211, 19)
        Me.Deletepermanent.Name = "Deletepermanent"
        Me.Deletepermanent.Size = New System.Drawing.Size(154, 22)
        Me.Deletepermanent.TabIndex = 59
        Me.Deletepermanent.Text = "Delete Permanently"
        Me.Deletepermanent.UseVisualStyleBackColor = True
        '
        'cb_cache
        '
        Me.cb_cache.FormattingEnabled = True
        Me.cb_cache.Items.AddRange(New Object() {"days", "weeks", "months"})
        Me.cb_cache.Location = New System.Drawing.Point(313, 195)
        Me.cb_cache.Name = "cb_cache"
        Me.cb_cache.Size = New System.Drawing.Size(66, 24)
        Me.cb_cache.TabIndex = 70
        Me.cb_cache.Text = "days"
        '
        'nud_cache
        '
        Me.nud_cache.Location = New System.Drawing.Point(274, 195)
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
        Me.Label3.Location = New System.Drawing.Point(3, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Delete images  from cache folders older than"
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
        'cb_Movies
        '
        Me.cb_Movies.AutoSize = True
        Me.cb_Movies.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Movies.Location = New System.Drawing.Point(16, 49)
        Me.cb_Movies.Name = "cb_Movies"
        Me.cb_Movies.Size = New System.Drawing.Size(129, 22)
        Me.cb_Movies.TabIndex = 62
        Me.cb_Movies.Text = "MovingPictures"
        Me.cb_Movies.UseVisualStyleBackColor = True
        '
        'Scheduler
        '
        Me.Scheduler.BackColor = System.Drawing.Color.Transparent
        Me.Scheduler.Controls.Add(Me.GroupBox5)
        Me.Scheduler.Controls.Add(Me.GroupBox4)
        Me.Scheduler.Controls.Add(Me.GroupBox3)
        Me.Scheduler.Controls.Add(Me.GroupBox2)
        Me.Scheduler.Location = New System.Drawing.Point(4, 25)
        Me.Scheduler.Name = "Scheduler"
        Me.Scheduler.Padding = New System.Windows.Forms.Padding(3)
        Me.Scheduler.Size = New System.Drawing.Size(385, 282)
        Me.Scheduler.TabIndex = 2
        Me.Scheduler.Text = "Scheduler"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cb_checktrigger)
        Me.GroupBox5.Controls.Add(Me.nud_checktrigger)
        Me.GroupBox5.Location = New System.Drawing.Point(192, 79)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(181, 62)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " Check trigger every "
        '
        'cb_checktrigger
        '
        Me.cb_checktrigger.FormattingEnabled = True
        Me.cb_checktrigger.Items.AddRange(New Object() {"seconds", "minutes", "hours"})
        Me.cb_checktrigger.Location = New System.Drawing.Point(68, 29)
        Me.cb_checktrigger.Name = "cb_checktrigger"
        Me.cb_checktrigger.Size = New System.Drawing.Size(80, 24)
        Me.cb_checktrigger.TabIndex = 10
        Me.cb_checktrigger.Text = "minutes"
        '
        'nud_checktrigger
        '
        Me.nud_checktrigger.Location = New System.Drawing.Point(21, 30)
        Me.nud_checktrigger.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nud_checktrigger.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_checktrigger.Name = "nud_checktrigger"
        Me.nud_checktrigger.Size = New System.Drawing.Size(43, 22)
        Me.nud_checktrigger.TabIndex = 8
        Me.nud_checktrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_checktrigger.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_pause)
        Me.GroupBox4.Location = New System.Drawing.Point(192, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(181, 62)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Functionality "
        '
        'cb_pause
        '
        Me.cb_pause.AutoSize = True
        Me.cb_pause.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cb_pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pause.Location = New System.Drawing.Point(8, 27)
        Me.cb_pause.Name = "cb_pause"
        Me.cb_pause.Size = New System.Drawing.Size(164, 19)
        Me.cb_pause.TabIndex = 16
        Me.cb_pause.Text = "Pause when player active"
        Me.cb_pause.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Size = New System.Drawing.Size(372, 131)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Trigger "
        '
        'cb_delay
        '
        Me.cb_delay.FormattingEnabled = True
        Me.cb_delay.Items.AddRange(New Object() {"seconds", "minutes", "hours"})
        Me.cb_delay.Location = New System.Drawing.Point(275, 30)
        Me.cb_delay.Name = "cb_delay"
        Me.cb_delay.Size = New System.Drawing.Size(80, 24)
        Me.cb_delay.TabIndex = 12
        Me.cb_delay.Text = "seconds"
        '
        'nud_delay
        '
        Me.nud_delay.Location = New System.Drawing.Point(226, 31)
        Me.nud_delay.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nud_delay.Name = "nud_delay"
        Me.nud_delay.Size = New System.Drawing.Size(44, 22)
        Me.nud_delay.TabIndex = 11
        Me.nud_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtb_cpu
        '
        Me.mtb_cpu.Location = New System.Drawing.Point(176, 60)
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
        Me.rb_cpu.Location = New System.Drawing.Point(11, 62)
        Me.rb_cpu.Name = "rb_cpu"
        Me.rb_cpu.Size = New System.Drawing.Size(168, 20)
        Me.rb_cpu.TabIndex = 8
        Me.rb_cpu.TabStop = True
        Me.rb_cpu.Text = "when CPU usage below"
        Me.rb_cpu.UseVisualStyleBackColor = True
        '
        'mtb_time
        '
        Me.mtb_time.Location = New System.Drawing.Point(44, 91)
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
        Me.rb_time.Location = New System.Drawing.Point(11, 92)
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
        Me.rb_startup.Location = New System.Drawing.Point(11, 31)
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
        Me.GroupBox2.Size = New System.Drawing.Size(179, 134)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Periodicity "
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
        'b_clean
        '
        Me.b_clean.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_clean.Location = New System.Drawing.Point(159, 333)
        Me.b_clean.Name = "b_clean"
        Me.b_clean.Size = New System.Drawing.Size(75, 23)
        Me.b_clean.TabIndex = 63
        Me.b_clean.Text = "Clean Now"
        Me.b_clean.UseVisualStyleBackColor = True
        '
        'MPCleanerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 365)
        Me.Controls.Add(Me.b_clean)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MPCleanerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MPCleaner v1.1.0.15"
        Me.TabControl1.ResumeLayout(False)
        Me.Plugins.ResumeLayout(False)
        Me.Plugins.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_cache, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scheduler.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.nud_checktrigger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Plugins As System.Windows.Forms.TabPage
    Friend WithEvents cb_YouTubefm As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Music As System.Windows.Forms.CheckBox
    Friend WithEvents cb_TVSeries As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cb_Movies As System.Windows.Forms.CheckBox
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
    Friend WithEvents cb_checktrigger As System.Windows.Forms.ComboBox
    Friend WithEvents cb_delay As System.Windows.Forms.ComboBox
    Friend WithEvents nud_delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_cache As System.Windows.Forms.ComboBox
    Friend WithEvents nud_cache As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_pause As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Deletetotrash As System.Windows.Forms.RadioButton
    Friend WithEvents Deletepermanent As System.Windows.Forms.RadioButton
    Friend WithEvents b_clean As System.Windows.Forms.Button
    Friend WithEvents cb_Pictures As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Videos As System.Windows.Forms.CheckBox
End Class
