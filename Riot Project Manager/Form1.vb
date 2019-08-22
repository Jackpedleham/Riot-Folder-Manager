Imports System.IO
Imports IronPdf


Public Class Form1

    'declare variables
    Dim projectname As String
    Dim client As String
    Dim number As String
    Dim email As String
    Dim contact As String
    Dim deadline As Date
    Dim ISinterior As Boolean
    Dim ISexterior As Boolean
    Dim ISrealtime As Boolean
    Dim ISproduct As Boolean
    Dim ISanimation As Boolean
    Dim ISvr As Boolean
    Dim notes As String
    Dim makefolders As Boolean
    Dim makebrief As Boolean
    Dim projectslocation As String
    Dim foldersbuilt As Boolean
    Dim projectroot As String
    Dim projectfiles As String
    Dim templatesroot As String
    Dim clientroot As String




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Build.Click


        'write file properties based on project settings i.e. name, company, category and comments
        'write template files with all settings set up and named properly
        'write project folder structure with renders folder and documentation folder
        'write mxp file
        'generate max file for correct template (interior exterior etc)
        'checkbox to include presets (exterior has forest grass etc set up)
        'generate pdf brief?
        'generate email customer link contact client mailto:
        Try
            SetVars()

            If Not Directory.Exists(projectroot) Then

                If cb_folders.Checked = True Then
                    Buildfolders()
                    ShortcutBuilder()
                    Templatefiles()
                    If cb_brief.Checked = True Then
                        GeneratePDF()
                    End If
                End If

            Else
                MsgBox("Project directory already Exists. Please choose another project name.")
            End If
        Catch ex As Exception
            MsgBox("Something is wrong!")
        End Try

    End Sub

    Private Sub SetVars()

        'build the root project folder path
        projectname = txt_projectname.Text
        client = txt_client.Text
        contact = txt_contact.Text
        email = txt_email.Text
        number = txt_number.Text
        notes = txt_notes.Text
        deadline = deadlinedate.Value
        templatesroot = s_templates.Text



        projectslocation = s_projects.Text

        projectroot = $"{projectslocation}/{client}/{projectname}_{Date.Now.ToString("ddMMyy")}"
        projectfiles = $"{projectroot}/{projectname} Project Files/"
        clientroot = $"{projectslocation}/{client}"
        'set project default directory

        'get the various fields set by the user

    End Sub

    Private Sub ShortcutBuilder()
        'declare variables
        Dim oShell As Object
        Dim oLink As Object
        Dim ShortCutPath As String
        Dim ShortCutName As String = "Email " & contact & " at " & client

        'build shortcut string
        ShortCutPath = "mailto:" & email & "?subject=" & projectname

        Try
            'create shell object and create a shortcut
            oShell = CreateObject("WScript.Shell")
            oLink = oShell.CreateShortcut(projectroot & "\" & ShortCutName & ".lnk")

            'set the target of the shortcut
            oLink.TargetPath = ShortCutPath

            oLink.WindowStyle = 1
            oLink.Save()
        Catch ex As Exception
            MsgBox("shortcut failed")
        End Try


    End Sub

    Private Sub Buildfolders()
        'BROKEN
        'create root folder
        If Not Directory.Exists(clientroot) Then
            Directory.CreateDirectory(clientroot)
            makedirectories()

        Else
            makedirectories()
        End If






    End Sub
    Private Sub makedirectories()
        Directory.CreateDirectory(projectroot)
        'create subfolders level 1
        Directory.CreateDirectory(projectroot & "\Renders")
        Directory.CreateDirectory(projectroot & "\Documentation")
        'create subfolders level 2
        Directory.CreateDirectory(projectroot & "\Renders\Test Renders")
        Directory.CreateDirectory(projectroot & "\Renders\Final Renders")
        Directory.CreateDirectory(projectroot & "\Documentation\Reference Photography")
        Directory.CreateDirectory(projectroot & "\Documentation\Mood Boards")
        Directory.CreateDirectory(projectfiles & "archives")
        Directory.CreateDirectory(projectfiles & "autoback")
        Directory.CreateDirectory(projectfiles & "downloads")
        Directory.CreateDirectory(projectfiles & "export")
        Directory.CreateDirectory(projectfiles & "import")
        Directory.CreateDirectory(projectfiles & "materiallibraries")
        Directory.CreateDirectory(projectfiles & "previews")
        Directory.CreateDirectory(projectfiles & "proxies")
        Directory.CreateDirectory(projectfiles & "renderoutput")
        Directory.CreateDirectory(projectfiles & "renderpresets")
        Directory.CreateDirectory(projectfiles & "renders")
        Directory.CreateDirectory(projectfiles & "sceneassets")
        Directory.CreateDirectory(projectfiles & "scenes")
        Directory.CreateDirectory(projectfiles & "vpost")
        'run shortcut builder to generate email link
    End Sub
    Private Sub Templatefiles()



        If cb_default.Checked = True Then

            My.Computer.FileSystem.CopyFile(templatesroot & "\MaxTemplate.Max", projectfiles & "/Scenes/" & client & "_" & projectname & ".max")

        End If

        If cb_interior.Checked = True Then

            My.Computer.FileSystem.CopyFile(templatesroot & "\MaxTemplate.Max", projectfiles & "/Scenes/" & client & "_" & projectname & "_Interior.max")

        End If

        If cb_exterior.Checked = True Then

            My.Computer.FileSystem.CopyFile(templatesroot & "\MaxTemplate.Max", projectfiles & "/Scenes/" & client & "_" & projectname & "_Exterior.max")

        End If



    End Sub

    Private Sub GeneratePDF()

        Dim renderer = New HtmlToPdf()
        Dim document As Object




        document = renderer.RenderHtmlAsPdf("<font face=""verdana""><img src='" & s_logo.Text & "'height=""58"" width=""200""><h1>" & projectname & "</h1>" & "<h2>Client: " & client & "</h2>" & "<h3>Key Contact: " & contact & "</h3>" & "<h3>Email Address: " & email & "</h3>" & "<h3>Contact Number: " & number & "</h3>" & "<h3>Deadline: " & deadline & "</h3>" & "<h4>Notes: " & notes & "</h4></font>")

        document.SaveAs(projectroot & "/" & projectname & " Project Information.pdf")
        System.Diagnostics.Process.Start(projectroot & "/" & projectname & " Project Information.pdf")




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        s_projects.Text = FolderBrowserDialog1.SelectedPath

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog2.ShowDialog()
        s_logo.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog3.ShowDialog()
        s_logo.Text = FolderBrowserDialog2.SelectedPath
    End Sub

    Private Sub s_projects_TextChanged(sender As Object, e As EventArgs) Handles s_projects.TextChanged

    End Sub
End Class
