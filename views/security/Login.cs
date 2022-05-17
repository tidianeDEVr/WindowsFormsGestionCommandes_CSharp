using System;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.dao.ado.net;
using WindowsFormsGestionCommandes.fabrique;
using WindowsFormsGestionCommandes.services;
using WindowsFormsGestionCommandes.views.home;

namespace WindowsFormsGestionCommandes.views.security
{
    public partial class Login : Form
    {
        private IService service = Fabrique.getInstanceService();
        public Login()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String login = loginTxtb.Text.Trim();
            String password = passwordTxtb.Text.Trim();
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login ou mot de passe obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                users_gc user = service.searchUserLoginAndPassword(login, password);
                
                if (user != null)
                {
                    //Redirection vers la page Accueil
                    switch (user.role.libelle)
                    {
                        case "ROLE_CLIENT":
                            HomeClient homePatient = new HomeClient(user);
                            homePatient.Show();
                            this.Hide();
                            break;
                        case "ROLE_SECRETAIRE":
                            HomeSecretaire homeSecretaire = new HomeSecretaire(user);
                            homeSecretaire.Show();
                            this.Hide();
                            break;
                        case "ROLE_RESP_STOCK":
                            HomeResponsable homeResp = new HomeResponsable(user);
                            homeResp.Show();
                            this.Hide();
                            break;
                        default:
                            HomeComptable homeComp = new HomeComptable(user);
                            homeComp.Show();
                            this.Hide();
                            break;
                    }
                }
                else 
                {
                    MessageBox.Show("Login ou mot de passe incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            loginTxtb.Clear();
            passwordTxtb.Clear();
        }
    }
}
