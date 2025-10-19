using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11_Ejercicio1
{
    internal class IComparer
    {
        public class Employee : IComparable<Employee>
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public int CompareTo(Employee other)
            {
                // Ordenar Ascendentemente
                // return this.Salary.CompareTo(other.Salary);

                // Ordenar Desendentemente
                // return other.Salary.CompareTo(this.Salary);

                // Ordenar por nombre
                // return this.Name.CompareTo(other.Name);

                /*
                 * Explicado en el libro
                    a. Si el valor es menor que cero significa que X es menor que Y.
                    b. Si el valor es cero significa que X en igual a Y.
                    c. Si el valor es mayor que cero significa que X es mayor que Y.
                 */

                // Si el salario es igual, entonces ordena por nombre
                // -1 -> menor
                // 0 -> igual
                // 1 -> mayor
                int salaryComparation = other.Salary.CompareTo(this.Salary);
                if (salaryComparation == 0) return this.Name.CompareTo(other.Name);
                return other.Salary.CompareTo(this.Salary);
            }
        }
    }
}
