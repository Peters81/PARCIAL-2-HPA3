namespace Presentacion;
internal static class Tema
{
    internal static readonly Color Rojo=Color.FromArgb(224,105,112);
    internal static readonly Color RojoOscuro=Color.FromArgb(178,61,70);
    internal static readonly Color Fondo=Color.FromArgb(249,246,246);
    internal static readonly Color Tinta=Color.FromArgb(56,45,49);
    internal static Button Boton(string texto)
    {
        var b=new Button { Text=texto,FlatStyle=FlatStyle.Flat,BackColor=Rojo,ForeColor=Color.White,
            Font=new Font("Segoe UI",11),Cursor=Cursors.Hand,Height=46,UseVisualStyleBackColor=false };
        b.FlatAppearance.BorderSize=0; b.FlatAppearance.MouseOverBackColor=RojoOscuro;
        return b;
    }
}
