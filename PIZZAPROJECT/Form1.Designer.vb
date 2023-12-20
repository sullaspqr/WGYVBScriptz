<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        txtQuantity = New TextBox()
        cboMembership = New ComboBox()
        chbPepperoni = New CheckBox()
        chbBacon = New CheckBox()
        chbCheese = New CheckBox()
        Label3 = New Label()
        rdbSuperspecial = New RadioButton()
        rdbSpecial = New RadioButton()
        rdbRegular = New RadioButton()
        Label2 = New Label()
        btnClear = New Button()
        Button2 = New Button()
        btnSubmit = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(102))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1101, 121)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.close
        PictureBox2.Location = New Point(996, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(72, 54)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(440, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 31)
        Label1.TabIndex = 0
        Label1.Text = "PIZZA PROJECT"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(102))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1101, 121)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.hawaiian_pizza_recipe_605894_2_2132987587
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 128)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1097, 515)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Black
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(cboMembership)
        GroupBox1.Controls.Add(chbPepperoni)
        GroupBox1.Controls.Add(chbBacon)
        GroupBox1.Controls.Add(chbCheese)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(rdbSuperspecial)
        GroupBox1.Controls.Add(rdbSpecial)
        GroupBox1.Controls.Add(rdbRegular)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(148, 141)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(748, 486)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "MENÜ"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(20, 433)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 28)
        Label5.TabIndex = 11
        Label5.Text = "Darabszám"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(20, 377)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 28)
        Label4.TabIndex = 10
        Label4.Text = "Tagság"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(153, 433)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(151, 27)
        txtQuantity.TabIndex = 9
        ' 
        ' cboMembership
        ' 
        cboMembership.FormattingEnabled = True
        cboMembership.Location = New Point(153, 377)
        cboMembership.Name = "cboMembership"
        cboMembership.Size = New Size(151, 28)
        cboMembership.TabIndex = 8
        ' 
        ' chbPepperoni
        ' 
        chbPepperoni.AutoSize = True
        chbPepperoni.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chbPepperoni.Location = New Point(69, 329)
        chbPepperoni.Name = "chbPepperoni"
        chbPepperoni.Size = New Size(217, 32)
        chbPepperoni.TabIndex = 7
        chbPepperoni.Text = "Pepperoni - 800 HUF"
        chbPepperoni.UseVisualStyleBackColor = True
        ' 
        ' chbBacon
        ' 
        chbBacon.AutoSize = True
        chbBacon.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chbBacon.Location = New Point(69, 288)
        chbBacon.Name = "chbBacon"
        chbBacon.Size = New Size(181, 32)
        chbBacon.TabIndex = 6
        chbBacon.Text = "Bacon - 700 HUF"
        chbBacon.UseVisualStyleBackColor = True
        ' 
        ' chbCheese
        ' 
        chbCheese.AutoSize = True
        chbCheese.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chbCheese.Location = New Point(69, 250)
        chbCheese.Name = "chbCheese"
        chbCheese.Size = New Size(161, 32)
        chbCheese.TabIndex = 5
        chbCheese.Text = "Sajt - 500 HUF"
        chbCheese.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(37, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 28)
        Label3.TabIndex = 4
        Label3.Text = "Plusz feltét"
        ' 
        ' rdbSuperspecial
        ' 
        rdbSuperspecial.AutoSize = True
        rdbSuperspecial.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdbSuperspecial.Location = New Point(69, 144)
        rdbSuperspecial.Name = "rdbSuperspecial"
        rdbSuperspecial.Size = New Size(258, 32)
        rdbSuperspecial.TabIndex = 3
        rdbSuperspecial.TabStop = True
        rdbSuperspecial.Text = "Családi 52 cm - 5000 HUF"
        rdbSuperspecial.UseVisualStyleBackColor = True
        ' 
        ' rdbSpecial
        ' 
        rdbSpecial.AutoSize = True
        rdbSpecial.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdbSpecial.Location = New Point(69, 103)
        rdbSpecial.Name = "rdbSpecial"
        rdbSpecial.Size = New Size(271, 32)
        rdbSpecial.TabIndex = 2
        rdbSpecial.TabStop = True
        rdbSpecial.Text = "Speciális 32 cm - 2500 HUF"
        rdbSpecial.UseVisualStyleBackColor = True
        ' 
        ' rdbRegular
        ' 
        rdbRegular.AutoSize = True
        rdbRegular.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdbRegular.Location = New Point(69, 64)
        rdbRegular.Name = "rdbRegular"
        rdbRegular.Size = New Size(322, 32)
        rdbRegular.TabIndex = 1
        rdbRegular.TabStop = True
        rdbRegular.Text = "Hagyományos 25 cm - 2000 HUF"
        rdbRegular.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(37, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 28)
        Label2.TabIndex = 0
        Label2.Text = "Rendelés"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(102))
        btnClear.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Location = New Point(912, 288)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(177, 85)
        btnClear.TabIndex = 12
        btnClear.Text = "Törlés"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(102))
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(912, 405)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 85)
        Button2.TabIndex = 13
        Button2.Text = "Hamarosan"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(102))
        btnSubmit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(920, 164)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(177, 85)
        btnSubmit.TabIndex = 13
        btnSubmit.Text = "Küldés"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(102))
        Button4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(912, 516)
        Button4.Name = "Button4"
        Button4.Size = New Size(177, 85)
        Button4.TabIndex = 13
        Button4.Text = "Hamarosan"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1101, 772)
        Controls.Add(Button4)
        Controls.Add(btnSubmit)
        Controls.Add(Button2)
        Controls.Add(btnClear)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbSuperspecial As RadioButton
    Friend WithEvents rdbSpecial As RadioButton
    Friend WithEvents rdbRegular As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMembership As ComboBox
    Friend WithEvents chbPepperoni As CheckBox
    Friend WithEvents chbBacon As CheckBox
    Friend WithEvents chbCheese As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
