<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.btnHerramientas = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHerramientas
        '
        Me.btnHerramientas.BackgroundImage = Global.Tarimera.My.Resources.Resources.tools
        Me.btnHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHerramientas.Location = New System.Drawing.Point(45, 83)
        Me.btnHerramientas.Name = "btnHerramientas"
        Me.btnHerramientas.Size = New System.Drawing.Size(120, 120)
        Me.btnHerramientas.TabIndex = 0
        Me.btnHerramientas.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.BackgroundImage = Global.Tarimera.My.Resources.Resources.portapapeles
        Me.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistro.Location = New System.Drawing.Point(190, 83)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(120, 120)
        Me.btnRegistro.TabIndex = 1
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.BackgroundImage = Global.Tarimera.My.Resources.Resources.user
        Me.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuario.Location = New System.Drawing.Point(334, 83)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(120, 120)
        Me.btnUsuario.TabIndex = 2
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tarimera.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(495, 317)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.btnHerramientas)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHerramientas As Button
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnUsuario As Button
End Class
