using Entidades;
using Negocio;
namespace Presentacion;
/// <summary>Vista de acceso: controles y navegación; delega la autenticación al presentador.</summary>
public partial class Form1 : Form, ILoginView
{
    private readonly LoginPresenter presenter;
    public Form1()
    {
        InitializeComponent(); Text="Inicio de sesión";
        StartPosition=FormStartPosition.CenterScreen;
        AcceptButton=btnIniciarSesion;
        presenter=new LoginPresenter(this,N_Usuario.Crear());
    }
    public string Usuario=>txtUsuario.Text;
    public string Password=>txtPassword.Text;
    public event EventHandler? IniciarSesion;
    private void btnIniciarSesion_Click(object? sender,EventArgs e)=>IniciarSesion?.Invoke(this,EventArgs.Empty);
    public void MostrarMensaje(string mensaje)=>MessageBox.Show(this,mensaje,"Inicio de sesión",MessageBoxButtons.OK,MessageBoxIcon.Information);
    public void SetOcupado(bool ocupado) { btnIniciarSesion.Enabled=!ocupado; UseWaitCursor=ocupado; }
    public void AbrirSesion(E_Usuario usuario)
    {
        txtPassword.Clear(); Hide();
        try { using var principal=new MainForm(usuario); principal.ShowDialog(); }
        finally { Show(); txtPassword.Focus(); }
    }
}
