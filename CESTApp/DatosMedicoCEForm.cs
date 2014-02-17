using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CESTApp
{
    public partial class DatosMedicoCEForm : Form
    {
        DBEntities BD = new DBEntities();   

        private bool ingresodatos;
        private MedicoCE medico;

        public MedicoCE Medico
        {
            get { return medico; }
            set { medico = value;
            LlenarControles();
            }
        }

        private int idmedico;

        public int Idmedico
        {
            get { return idmedico; }
            set
            {
                idmedico = value;
                LlenarControles();
            }
        }

        public DatosMedicoCEForm()
        {
            InitializeComponent();
        }

        private void LlenarObjeto()
        {
            if (idmedico == 0)
            {
                MedicoCE nuevomedico = new MedicoCE(); //crear el objeto
                nuevomedico.Id = this.IdTxt.Value;
                nuevomedico.Nombre = this.NombreTxt.Text;
                nuevomedico.Apellidos = this.ApellidosTxt.Text;
                nuevomedico.Especialidad = this.EspecialidadCargoTxt.Text;
                nuevomedico.CedulaProfesional = this.CedulaNTxt.Value;

                //this.medico.Areas = new List<Area>(); //inicializamos las areas del Medico

                //Agregar las areas seleccionadas al Medico
                if (this.DeptoTomografiaChk.Checked)
                    nuevomedico.AreaMedico.Add(new AreaMedico { MedicoCE = nuevomedico, Area = BD.Area.Where(a => a.Nombre == "Tomografía").FirstOrDefault() });

                if (this.DeptoRadiografiaChk.Checked)
                    nuevomedico.AreaMedico.Add(new AreaMedico { MedicoCE = nuevomedico, Area = BD.Area.Where(a => a.Nombre == "Radiografía").FirstOrDefault() });

                if (this.DeptoUltrasonidoChk.Checked)
                    nuevomedico.AreaMedico.Add(new AreaMedico { MedicoCE = nuevomedico, Area = BD.Area.Where(a => a.Nombre == "Ultrasonido").FirstOrDefault() });

                //if (this.DeptoTomografiaChk.Checked)
                //    this.medico.Areas.Add(areas.Where(a => a.Nombre == "Tomografía").FirstOrDefault());

                BD.AddToMedicoCE(nuevomedico);
                BD.SaveChanges();
            }
            else
            {

                this.medico.Id = this.IdTxt.Value;
                this.medico.Nombre = this.NombreTxt.Text;
                this.medico.Apellidos = this.ApellidosTxt.Text;
                this.medico.Especialidad = this.EspecialidadCargoTxt.Text;
                this.medico.CedulaProfesional = this.CedulaNTxt.Value;

                BD.SaveChanges();
            }
        }

        private void LlenarControles()
        {
            medico = BD.MedicoCE.Where(m => m.Id == idmedico).SingleOrDefault();

            if (medico != null)
            {
                this.IdTxt.Text = this.medico.Id.ToString();
                this.NombreTxt.Text = this.medico.Nombre.TrimEnd();
                this.ApellidosTxt.Text = this.medico.Apellidos.TrimEnd();
                this.EspecialidadCargoTxt.Text = this.medico.Especialidad.TrimEnd();
                this.CedulaNTxt.Text = this.medico.CedulaProfesional.ToString();

                //Cargar las Areas
                foreach (AreaMedico areamedico in this.medico.AreaMedico)
                {
                    switch(areamedico.Area.Nombre.Trim())
                    {
                        case "Tomografía":
                        this.DeptoTomografiaChk.Checked = true;
                        break;

                        case "Radiografía":
                        this.DeptoRadiografiaChk.Checked = true;
                            break;

                        case "Ultrasonido":
                        this.DeptoUltrasonidoChk.Checked = true;
                        break;
                }
                }

            }


        }

        public bool IngresoDatos()
        {
            return this.ingresodatos;
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (this.NombreTxt.Text != "" && this.ApellidosTxt.Text != "" && this.EspecialidadCargoTxt.Text != ""
                && this.CedulaNTxt.Value != 0)
            {
                LlenarObjeto();
                this.ingresodatos = true;
                this.Close();
            }
            else
                MessageBox.Show("Ingrese los datos del médico.");
        }


        private void DeptoTomografiaChk_Click(object sender, EventArgs e)
        {
            if (this.medico != null) //solo si se esta editando
            {
                if (this.DeptoTomografiaChk.Checked) //si lo selecciona el usuario, agregar el area al medico
                    this.medico.AreaMedico.Add(new AreaMedico { Area = BD.Area.Where(a => a.Nombre == "Tomografía").FirstOrDefault(), MedicoCE = medico });
                else
                    BD.AreaMedico.DeleteObject(BD.AreaMedico.Where(am => am.IdMedico == medico.Id && am.Area.Nombre == "Tomografía").First());

                BD.SaveChanges();
            }
        }

        private void DeptoRadiografiaChk_Click(object sender, EventArgs e)
        {
            if (this.medico != null) //solo si se esta editando
            {
                var area = BD.Area.Where(a => a.Nombre.TrimEnd() == "Radiografía").FirstOrDefault();
                if (this.DeptoRadiografiaChk.Checked) //si lo selecciona el usuario, agregar el area al medico
                    this.medico.AreaMedico.Add(new AreaMedico { Area = BD.Area.Where(a => a.Nombre == "Radiografía").FirstOrDefault(), MedicoCE = medico });
                else
                    BD.AreaMedico.DeleteObject(BD.AreaMedico.Where(am => am.IdMedico == medico.Id && am.Area.Nombre == "Radiografía").FirstOrDefault());

                BD.SaveChanges();
            }
        }

        private void DeptoUltrasonidoChk_Click(object sender, EventArgs e)
        {
            if (this.medico != null) //solo si se esta editando
            {
                if (this.DeptoUltrasonidoChk.Checked) //si lo selecciona el usuario, agregar el area al medico
                    this.medico.AreaMedico.Add(new AreaMedico { Area = BD.Area.Where(a => a.Nombre == "Ultrasonido").FirstOrDefault(), MedicoCE = medico });
                else
                    BD.AreaMedico.DeleteObject(BD.AreaMedico.Where(am => am.IdMedico == medico.Id && am.Area.Nombre == "Ultrasonido").FirstOrDefault());

                BD.SaveChanges();
            }
        }

    }
}
