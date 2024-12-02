using SalazarEExamenProgreso2.Interfaces;
using SalazarEExamenProgreso2.Models;
using SalazarEExamenProgreso2.Repositories;

namespace SalazarEExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        IUsuarioRepository _usuarioRepository;
        Usuario usuario = new Usuario();

        public MainPage()
        {
            
            _usuarioRepository = new UsuarioProArchivosRepository();
            usuario = _usuarioRepository.DevuelveUsuario();
            InitializeComponent();
            BindingContext = usuario;
        }

        private async void Recargar_Clicked(object sender, EventArgs e)
        {
            Usuario usu = new Usuario
            {
                Nombre = esalazar_editor_Name.Text,
                Numero = esalazar_editor_Telefono.Text,

            };
            bool guardar_usuario = _usuarioRepository.CrearUsuario(usu);

            if (guardar_usuario)
            {
                await DisplayAlert("Alerta", "El numero de telefono se valido correctamente", "Ok");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "El numero de telefono no se valido", "Ok");
                Navigation.PushAsync(new MainPage());
            }
        }
    }

}
