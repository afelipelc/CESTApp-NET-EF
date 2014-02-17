using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//agregamos el uso de
using System.Data.Objects;
using System.Data.Objects.DataClasses;
//para poder usar el data entity model

namespace CESTApp
{        
    public partial class DatosUsuarioFrm : Form
    {
        DBEntities BD = new DBEntities();        
        private bool ingresodatos;
        private Usuario usuario;
        private int idmedico;

        private int idusuario;
        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value;
            //CargarDatos();
            }
        }



        public bool IngresoDatos()
        {          
            return this.ingresodatos;
        }

        public DatosUsuarioFrm()
        {
            InitializeComponent();
        }

        private void LlenarDatos()
        {           
            if (idusuario ==0) //se creara el nuevo usuario
            {
                Usuario nuevousuario = new Usuario();
                nuevousuario.Id = this.IdTxt.Value;
                nuevousuario.NombreUsuario = this.NombreUsrTxt.Text;
                nuevousuario.Nombre = this.NombreTxt.Text;
                nuevousuario.Apellidos = this.NombreUsrTxt.Text;
                nuevousuario.Activo = this.ActivoChk.Checked;
                nuevousuario.Password = this.PasswordTxt.Text;

                //guardar usuario
                if (this.RolAdministradorChk.Checked)
                    nuevousuario.Rol.Add(new Rol { Usuario = nuevousuario, Nombre = "Administrador" });

                if (this.RolCajaChk.Checked)
                    nuevousuario.Rol.Add(new Rol { Usuario = nuevousuario, Nombre = "Caja" });

                if (this.RolMedicoChk.Checked)
                    nuevousuario.Rol.Add(new Rol { Usuario = nuevousuario, Nombre = "Medico" });

                if (this.RolRecepcionistaChk.Checked)
                    nuevousuario.Rol.Add(new Rol { Usuario = nuevousuario, Nombre = "Recepcion" });

                //si es un medico como usuario, crear la relacion
                if (this.UsuarioMedicoChk.Checked)
                {                   
                        //recuperar los datos completos del medico
                        AuxPersona auxiliar = (AuxPersona)this.MedicoCmb.SelectedItem;
                        if (auxiliar != null && auxiliar.Id > 0)
                        {
                            var medico = BD.MedicoCE.Where(m => m.Id == auxiliar.Id).FirstOrDefault();
                            nuevousuario.UsuarioMedico.Add(new UsuarioMedico { MedicoCE = medico, Usuario = usuario });
                        }
                    
                }                


                BD.AddToUsuario(nuevousuario);
               
                BD.SaveChanges();
                
            }
            else
            {
                this.usuario.Id = this.IdTxt.Value;
                this.usuario.NombreUsuario = this.NombreUsrTxt.Text;
                this.usuario.Password = this.PasswordTxt.Text;
                this.usuario.Nombre = this.NombreTxt.Text;
                this.usuario.Apellidos = this.ApellidosTxt.Text;
                this.usuario.Activo = this.ActivoChk.Checked;


                //eliminar cualquier relacion medico - usuario ya existente para volver a crear la nueva
                var relacionesusuariomedico = BD.UsuarioMedico.Where(um => um.IdUsuario == this.idusuario);
                foreach (UsuarioMedico relacion in relacionesusuariomedico)
                    BD.UsuarioMedico.DeleteObject(relacion);

                //BD.SaveChanges();
                //si es un medico como usuario, crear o volver a crear la relacion
                if (this.UsuarioMedicoChk.Checked)
                {
                        //recuperar los datos completos del medico
                        AuxPersona auxiliar = (AuxPersona)this.MedicoCmb.SelectedItem;
                        if (auxiliar != null && auxiliar.Id > 0)
                        {
                            var medico = BD.MedicoCE.Where(m => m.Id == auxiliar.Id).FirstOrDefault();
                            usuario.UsuarioMedico.Add(new UsuarioMedico { MedicoCE = medico, Usuario = usuario });
                        }
                        else
                        {
                            MessageBox.Show("Seleccione el médico que desea agregar como usuario", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.MedicoCmb.Focus();
                            return;
                        }
                 }
            

                BD.SaveChanges();

            }
        }

        private void CargarDatos()
        {
            usuario = BD.Usuario.Where(u => u.Id == idusuario).FirstOrDefault();
            if (usuario != null)
            {
                this.IdTxt.Text = usuario.Id.ToString();
                this.NombreTxt.Text = usuario.Nombre.TrimEnd();
                this.ApellidosTxt.Text = usuario.Apellidos.TrimEnd();
                this.NombreUsrTxt.Text = usuario.NombreUsuario.TrimEnd();
                this.PasswordTxt.Text = usuario.Password.TrimEnd();
                this.RePasswordTxt.Text = usuario.Password.TrimEnd();

                this.ActivoChk.Checked = usuario.Activo;

                var usuariomedico = BD.UsuarioMedico.Where(u => u.IdUsuario == usuario.Id).FirstOrDefault();

                //si es medico, activar el combo y deshabilitar el checkbox
                if (usuariomedico != null)
                {
                    this.UsuarioMedicoChk.Checked = true;
                    //this.MedicoCmb.Text = usuario.Nombre.TrimEnd() + " " + usuario.Apellidos.TrimEnd();
                    this.MedicoCmb.Text = usuariomedico.MedicoCE.Nombre.TrimEnd() + " " + usuariomedico.MedicoCE.Apellidos.TrimEnd();
                    this.idmedico = usuariomedico.IdMedico;                    
                }

                foreach (Rol rol in usuario.Rol)
                {
                    switch(rol.Nombre.Trim())
                    {
                        case "Administrador":
                            this.RolAdministradorChk.Checked = true;
                            break;

                        case "Caja":
                            this.RolCajaChk.Checked = true;
                            break;

                        case "Medico":
                            this.RolMedicoChk.Checked = true;
                            break;

                        case "Recepcion":
                            this.RolRecepcionistaChk.Checked = true;
                            break;
                    }

                }
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (this.NombreTxt.Text == "" || this.ApellidosTxt.Text == "")
            {
                MessageBox.Show("Ingrese el nombre y apellidos del usuario.");
                this.NombreTxt.Focus();
                return;
            }

            if (this.NombreUsrTxt.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de usuario.");
                this.NombreUsrTxt.Focus();
                return;
            }

            if (this.PasswordTxt.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña para de usuario.");
                this.PasswordTxt.Focus();
                return;
            }

            if (this.PasswordTxt.Text != this.RePasswordTxt.Text)
            {
                MessageBox.Show("La contraseña escrita y confirmar contraseña no coinciden.");
                this.RePasswordTxt.Text = "";
                this.RePasswordTxt.Focus();
                return;
            }

            //if (this.RolCmb.Text == "")
            //{
            //    MessageBox.Show("Seleccione el Rol para el usuario");
            //    this.RolCmb.Focus();               
            //    return;
            //}

            LlenarDatos();
            this.ingresodatos = true;
            this.Close();
        }

        private void UsuarioMedicoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.UsuarioMedicoChk.Checked)
            {
                if (this.MedicoCmb.DataSource != null)
                {

                    this.MedicoCmb.Enabled = true;
                    this.NombreTxt.Enabled = false;
                    this.ApellidosTxt.Enabled = false;
                    this.NombreTxt.Text = "";
                    this.ApellidosTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Aún no se han registrado los médicos", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.UsuarioMedicoChk.Checked = false;
                }
            }
            else
            {                
                this.MedicoCmb.Enabled = false;
                this.NombreTxt.Enabled = true;
                this.ApellidosTxt.Enabled = true;
                this.MedicoCmb.Text = "";
                if (usuario == null)
                {
                    this.NombreTxt.Text = "";
                    this.ApellidosTxt.Text = "";
                }
                else
                {
                    this.NombreTxt.Text = usuario.Nombre.TrimEnd();
                    this.ApellidosTxt.Text = usuario.Apellidos.TrimEnd();
                }
                this.NombreTxt.Focus();
            }
        }

        private void DatosUsuarioFrm_Load(object sender, EventArgs e)
        {


            var medicosce = BD.MedicoCE.Select(m => new AuxPersona { Id = m.Id, Nombre = m.Nombre.TrimEnd() + " " + m.Apellidos.TrimEnd()}).ToList();

            if (medicosce.Count > 0)
            {
                medicosce.Insert(0, new AuxPersona { Id = 0, Nombre = "" });
                this.MedicoCmb.DataSource = medicosce.ToList();

                this.MedicoCmb.DisplayMember = "Nombre";
            }

            if(idusuario!=0)
                CargarDatos();

        }

        private void MedicoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.UsuarioMedicoChk.Checked)
            {
                //recuperar los datos completos del medico
                AuxPersona auxiliar = (AuxPersona) this.MedicoCmb.SelectedItem;
                if (auxiliar != null && auxiliar.Id > 0)
                {
                    var medico = BD.MedicoCE.Where(m => m.Id == auxiliar.Id).FirstOrDefault();
                    this.NombreTxt.Text = medico.Nombre.TrimEnd();
                    this.ApellidosTxt.Text = medico.Apellidos.TrimEnd();
                    this.idmedico = auxiliar.Id;
                }
            }
        }

        private void RolAdministradorChk_Click(object sender, EventArgs e)
        {
            if (this.usuario != null)
            {
                if (this.RolAdministradorChk.Checked)
                    this.usuario.Rol.Add(new Rol { Usuario = usuario, Nombre = "Administrador" });
                else
                    BD.Rol.DeleteObject(BD.Rol.Where(r => r.IdUsuario == usuario.Id && r.Nombre == "Administrador").First());
                BD.SaveChanges();
            }
        }

        private void RolRecepcionistaChk_Click(object sender, EventArgs e)
        {
            if (this.usuario != null)
            {
                if (this.RolRecepcionistaChk.Checked)
                    this.usuario.Rol.Add(new Rol { Usuario = usuario, Nombre = "Recepcion" });
                else
                    BD.Rol.DeleteObject(BD.Rol.Where(r => r.IdUsuario == usuario.Id && r.Nombre == "Recepcion").First());

                BD.SaveChanges();
            }
        }

        private void RolCajaChk_Click(object sender, EventArgs e)
        {
            if (this.usuario != null)
            {
                if (this.RolCajaChk.Checked)
                    this.usuario.Rol.Add(new Rol { Usuario = usuario, Nombre = "Caja" });
                else
                    BD.Rol.DeleteObject(BD.Rol.Where(r => r.IdUsuario == usuario.Id && r.Nombre == "Caja").First());

                BD.SaveChanges();
            }
        }

        private void RolMedicoChk_Click(object sender, EventArgs e)
        {
            if (this.usuario != null)
            {
                if (this.RolMedicoChk.Checked)
                    this.usuario.Rol.Add(new Rol { Usuario = usuario, Nombre = "Medico" });
                else
                    BD.Rol.DeleteObject(BD.Rol.Where(r => r.IdUsuario == usuario.Id && r.Nombre == "Medico").First());

                BD.SaveChanges();
            }
        }

        private void MedicoCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
