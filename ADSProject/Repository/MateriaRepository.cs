using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly List<MateriaViewModel> lstMaterias;

        public MateriaRepository()
        {
            lstMaterias = new List<MateriaViewModel>
            {
                new MateriaViewModel{ idmateria =1 , nombreMateria = "Analisia de Sistemas"}
            };
        }

        public int agregarMaterias(MateriaViewModel materiaViewModel)
        {
            try
            {
             
                if(lstMaterias.Count > 0)
                {
                    materiaViewModel.idmateria = lstMaterias.Last().idmateria + 1;
                }
                else
                {
                    materiaViewModel.idmateria = 1;

                }
                lstMaterias.Add(materiaViewModel);
                return materiaViewModel.idmateria;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarMateria(int idMateria, MateriaViewModel materiaViewModel)
        {
            try
            {
                lstMaterias[lstMaterias.FindIndex(x => x.idmateria == idMateria)] = materiaViewModel;
                return materiaViewModel.idmateria;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarMateria(int idMateria)
        {
            try
            {
                lstMaterias.RemoveAt(lstMaterias.FindIndex(x => x.idmateria == idMateria));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MateriaViewModel obtenerMateriaPorID(int idMateria)
        {
            try
            {
                var item = lstMaterias.Find(x => x.idmateria == idMateria);
                return item;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MateriaViewModel> obtenerMaterias()
        {
            try
            {
                return lstMaterias;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
