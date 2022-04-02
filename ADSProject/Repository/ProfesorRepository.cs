using ADSProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProyect.Repository
{
    public class ProfesorRepository : IProfesorRepository
    {
        private readonly List<ProfesoresViewModel> lstProfesores;

        public ProfesorRepository()
        {
            lstProfesores = new List<ProfesoresViewModel>
            {
                new ProfesoresViewModel{ idProfesor = 1, nombreProfesor = "Juan", apellidoProfesor = "Perez",
                     correoProfesor = "Juan@usonsonate.edu.sv"}
            };
        }

        public int agregarProfesor(ProfesoresViewModel profesoresViewModel)
        {
            try
            {
                if (lstProfesores.Count > 0)
                {
                    profesoresViewModel.idProfesor = lstProfesores.Last().idProfesor + 1;
                }
                else
                {
                    profesoresViewModel.idProfesor = 1;
                }
                lstProfesores.Add(profesoresViewModel);
                return profesoresViewModel.idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarProfesor(int idProfesor, ProfesoresViewModel profesoresViewModel)
        {
            try
            {
                lstProfesores[lstProfesores.FindIndex(x => x.idProfesor == idProfesor)] = profesoresViewModel;
                return profesoresViewModel.idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarProfesor(int idProfesor)
        {
            try
            {
                lstProfesores.RemoveAt(lstProfesores.FindIndex(x => x.idProfesor == idProfesor));
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ProfesoresViewModel obtenerProfesorPorID(int idProfesor)
        {
            try
            {
                var item = lstProfesores.Find(x => x.idProfesor == idProfesor);
                return item;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<ProfesoresViewModel> obtenerProfesores()
        {
            {
                try
                {
                    return lstProfesores;
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

    }
}
