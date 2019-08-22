<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_Build = New System.Windows.Forms.Button()
        Me.txt_projectname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_client = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_folders = New System.Windows.Forms.CheckBox()
        Me.cb_brief = New System.Windows.Forms.CheckBox()
        Me.txt_notes = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cb_studio = New System.Windows.Forms.CheckBox()
        Me.cb_default = New System.Windows.Forms.CheckBox()
        Me.deadlinedate = New System.Windows.Forms.DateTimePicker()
        Me.cb_rt = New System.Windows.Forms.CheckBox()
        Me.cb_vr = New System.Windows.Forms.CheckBox()
        Me.cb_exterior = New System.Windows.Forms.CheckBox()
        Me.cb_animation = New System.Windows.Forms.CheckBox()
        Me.cb_product = New System.Windows.Forms.CheckBox()
        Me.cb_interior = New System.Windows.Forms.CheckBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.s_templates = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.s_logo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.s_projects = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LBL_VERSION = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Build
        '
        Me.btn_Build.Location = New System.Drawing.Point(161, 433)
        Me.btn_Build.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Build.Name = "btn_Build"
        Me.btn_Build.Size = New System.Drawing.Size(204, 49)
        Me.btn_Build.TabIndex = 0
        Me.btn_Build.Text = "Build Project"
        Me.btn_Build.UseVisualStyleBackColor = True
        '
        'txt_projectname
        '
        Me.txt_projectname.Location = New System.Drawing.Point(144, 11)
        Me.txt_projectname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_projectname.Name = "txt_projectname"
        Me.txt_projectname.Size = New System.Drawing.Size(220, 22)
        Me.txt_projectname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Project Name"
        '
        'txt_client
        '
        Me.txt_client.Location = New System.Drawing.Point(144, 43)
        Me.txt_client.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_client.Name = "txt_client"
        Me.txt_client.Size = New System.Drawing.Size(220, 22)
        Me.txt_client.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(144, 75)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(220, 22)
        Me.txt_contact.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Key Contact Name"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(144, 107)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(220, 22)
        Me.txt_email.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Deadline"
        '
        'cb_folders
        '
        Me.cb_folders.AutoSize = True
        Me.cb_folders.Checked = True
        Me.cb_folders.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_folders.Location = New System.Drawing.Point(12, 433)
        Me.cb_folders.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_folders.Name = "cb_folders"
        Me.cb_folders.Size = New System.Drawing.Size(141, 21)
        Me.cb_folders.TabIndex = 4
        Me.cb_folders.Text = "Generate Folders"
        Me.cb_folders.UseVisualStyleBackColor = True
        '
        'cb_brief
        '
        Me.cb_brief.AutoSize = True
        Me.cb_brief.Checked = True
        Me.cb_brief.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_brief.Location = New System.Drawing.Point(12, 462)
        Me.cb_brief.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_brief.Name = "cb_brief"
        Me.cb_brief.Size = New System.Drawing.Size(123, 21)
        Me.cb_brief.TabIndex = 4
        Me.cb_brief.Text = "Generate Brief"
        Me.cb_brief.UseVisualStyleBackColor = True
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(11, 282)
        Me.txt_notes.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(353, 143)
        Me.txt_notes.TabIndex = 5
        Me.txt_notes.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 262)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Notes"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 141)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 518)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.cb_studio)
        Me.TabPage1.Controls.Add(Me.cb_default)
        Me.TabPage1.Controls.Add(Me.deadlinedate)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_notes)
        Me.TabPage1.Controls.Add(Me.btn_Build)
        Me.TabPage1.Controls.Add(Me.cb_brief)
        Me.TabPage1.Controls.Add(Me.txt_projectname)
        Me.TabPage1.Controls.Add(Me.cb_rt)
        Me.TabPage1.Controls.Add(Me.cb_vr)
        Me.TabPage1.Controls.Add(Me.cb_exterior)
        Me.TabPage1.Controls.Add(Me.cb_animation)
        Me.TabPage1.Controls.Add(Me.cb_product)
        Me.TabPage1.Controls.Add(Me.cb_interior)
        Me.TabPage1.Controls.Add(Me.cb_folders)
        Me.TabPage1.Controls.Add(Me.txt_client)
        Me.TabPage1.Controls.Add(Me.txt_contact)
        Me.TabPage1.Controls.Add(Me.txt_number)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(376, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Project"
        '
        'cb_studio
        '
        Me.cb_studio.AutoSize = True
        Me.cb_studio.Enabled = False
        Me.cb_studio.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cb_studio.Location = New System.Drawing.Point(285, 236)
        Me.cb_studio.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_studio.Name = "cb_studio"
        Me.cb_studio.Size = New System.Drawing.Size(70, 21)
        Me.cb_studio.TabIndex = 7
        Me.cb_studio.Text = "Studio"
        Me.cb_studio.UseVisualStyleBackColor = True
        '
        'cb_default
        '
        Me.cb_default.AutoSize = True
        Me.cb_default.Checked = True
        Me.cb_default.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_default.Location = New System.Drawing.Point(12, 212)
        Me.cb_default.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_default.Name = "cb_default"
        Me.cb_default.Size = New System.Drawing.Size(75, 21)
        Me.cb_default.TabIndex = 8
        Me.cb_default.Text = "Default"
        Me.cb_default.UseVisualStyleBackColor = True
        '
        'deadlinedate
        '
        Me.deadlinedate.Location = New System.Drawing.Point(144, 174)
        Me.deadlinedate.Margin = New System.Windows.Forms.Padding(4)
        Me.deadlinedate.Name = "deadlinedate"
        Me.deadlinedate.Size = New System.Drawing.Size(220, 22)
        Me.deadlinedate.TabIndex = 6
        '
        'cb_rt
        '
        Me.cb_rt.AutoSize = True
        Me.cb_rt.Enabled = False
        Me.cb_rt.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cb_rt.Location = New System.Drawing.Point(193, 212)
        Me.cb_rt.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_rt.Name = "cb_rt"
        Me.cb_rt.Size = New System.Drawing.Size(85, 21)
        Me.cb_rt.TabIndex = 4
        Me.cb_rt.Text = "Realtime"
        Me.cb_rt.UseVisualStyleBackColor = True
        '
        'cb_vr
        '
        Me.cb_vr.AutoSize = True
        Me.cb_vr.Enabled = False
        Me.cb_vr.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cb_vr.Location = New System.Drawing.Point(193, 236)
        Me.cb_vr.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_vr.Name = "cb_vr"
        Me.cb_vr.Size = New System.Drawing.Size(49, 21)
        Me.cb_vr.TabIndex = 4
        Me.cb_vr.Text = "VR"
        Me.cb_vr.UseVisualStyleBackColor = True
        '
        'cb_exterior
        '
        Me.cb_exterior.AutoSize = True
        Me.cb_exterior.Location = New System.Drawing.Point(93, 212)
        Me.cb_exterior.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_exterior.Name = "cb_exterior"
        Me.cb_exterior.Size = New System.Drawing.Size(78, 21)
        Me.cb_exterior.TabIndex = 4
        Me.cb_exterior.Text = "Exterior"
        Me.cb_exterior.UseVisualStyleBackColor = True
        '
        'cb_animation
        '
        Me.cb_animation.AutoSize = True
        Me.cb_animation.Enabled = False
        Me.cb_animation.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cb_animation.Location = New System.Drawing.Point(93, 236)
        Me.cb_animation.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_animation.Name = "cb_animation"
        Me.cb_animation.Size = New System.Drawing.Size(92, 21)
        Me.cb_animation.TabIndex = 4
        Me.cb_animation.Text = "Animation"
        Me.cb_animation.UseVisualStyleBackColor = True
        '
        'cb_product
        '
        Me.cb_product.AutoSize = True
        Me.cb_product.Enabled = False
        Me.cb_product.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.cb_product.Location = New System.Drawing.Point(285, 212)
        Me.cb_product.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_product.Name = "cb_product"
        Me.cb_product.Size = New System.Drawing.Size(79, 21)
        Me.cb_product.TabIndex = 4
        Me.cb_product.Text = "Product"
        Me.cb_product.UseVisualStyleBackColor = True
        '
        'cb_interior
        '
        Me.cb_interior.AutoSize = True
        Me.cb_interior.Location = New System.Drawing.Point(12, 236)
        Me.cb_interior.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_interior.Name = "cb_interior"
        Me.cb_interior.Size = New System.Drawing.Size(74, 21)
        Me.cb_interior.TabIndex = 4
        Me.cb_interior.Text = "Interior"
        Me.cb_interior.UseVisualStyleBackColor = True
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(144, 139)
        Me.txt_number.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(220, 22)
        Me.txt_number.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contact Number"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.s_templates)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.s_logo)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.s_projects)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(376, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 177)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 182)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Templates"
        '
        's_templates
        '
        Me.s_templates.Location = New System.Drawing.Point(14, 205)
        Me.s_templates.Margin = New System.Windows.Forms.Padding(4)
        Me.s_templates.Name = "s_templates"
        Me.s_templates.Size = New System.Drawing.Size(340, 22)
        Me.s_templates.TabIndex = 9
        Me.s_templates.Text = "\\UNIX3\RIOT Library\RPM"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(252, 101)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 26)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Logo"
        '
        's_logo
        '
        Me.s_logo.Location = New System.Drawing.Point(15, 129)
        Me.s_logo.Margin = New System.Windows.Forms.Padding(4)
        Me.s_logo.Name = "s_logo"
        Me.s_logo.Size = New System.Drawing.Size(340, 22)
        Me.s_logo.TabIndex = 6
        Me.s_logo.Text = "\\UNIX2\raid\RIOT_BRANDING_STUFF\logo.jpg"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(252, 22)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Projects Location"
        '
        's_projects
        '
        Me.s_projects.Location = New System.Drawing.Point(15, 50)
        Me.s_projects.Margin = New System.Windows.Forms.Padding(4)
        Me.s_projects.Name = "s_projects"
        Me.s_projects.Size = New System.Drawing.Size(340, 22)
        Me.s_projects.TabIndex = 3
        Me.s_projects.Text = "\\FARNSWORTH\Projects"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Turquoise
        Me.Label10.Location = New System.Drawing.Point(116, 96)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(187, 29)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Project Builder"
        '
        'LBL_VERSION
        '
        Me.LBL_VERSION.AutoSize = True
        Me.LBL_VERSION.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LBL_VERSION.Location = New System.Drawing.Point(363, 15)
        Me.LBL_VERSION.Name = "LBL_VERSION"
        Me.LBL_VERSION.Size = New System.Drawing.Size(37, 17)
        Me.LBL_VERSION.TabIndex = 9
        Me.LBL_VERSION.Text = "V0.1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 672)
        Me.Controls.Add(Me.LBL_VERSION)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RIOT Project Builder"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Build As Button
    Friend WithEvents txt_projectname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_client As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_folders As CheckBox
    Friend WithEvents cb_brief As CheckBox
    Friend WithEvents txt_notes As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents deadlinedate As DateTimePicker
    Friend WithEvents cb_rt As CheckBox
    Friend WithEvents cb_vr As CheckBox
    Friend WithEvents cb_exterior As CheckBox
    Friend WithEvents cb_animation As CheckBox
    Friend WithEvents cb_product As CheckBox
    Friend WithEvents cb_interior As CheckBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents s_logo As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents s_projects As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents cb_studio As CheckBox
    Friend WithEvents cb_default As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents s_templates As TextBox
    Friend WithEvents FolderBrowserDialog3 As FolderBrowserDialog
    Friend WithEvents LBL_VERSION As Label
End Class
