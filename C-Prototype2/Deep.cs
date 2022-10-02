using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Prototype2
{
    public class Deep //Profundo
    {
        //Se usa cuando tenes un objeto que a su vez tiene otro objeto adentro.
        //Si intentas clonar es con un shallow no te va a dejar. Clona solo superficial el otro.
        public void UserInterface()
        {
            Animals animal = new Animals() { Name = "Ganzo", Paws = 2};
            animal.Caracteristics = new Details();
            animal.Caracteristics.Color = "White";
            animal.Caracteristics.ScientificName = "El pajaro menso";

            Animals clonedAnimal = animal.Clone() as Animals;
            clonedAnimal.Name = "Tucan";
            clonedAnimal.Caracteristics.Color = "Black";
            clonedAnimal.Caracteristics.ScientificName = "El pajaro tropical";

            Console.WriteLine($"Original animal: {animal.Caracteristics.ScientificName} \r\nCloned animal: {clonedAnimal.Caracteristics.ScientificName}");
        }
    }

    //It's in plural because of we can't use two same public classname on the same NameSpace.
    public class Animals : ICloneable
    {
        public int Paws { get; set; }
        public string Name { get; set; }
        
        public Details Caracteristics { get; set; }
        public object Clone()
        {
            Animals cloned = this.MemberwiseClone() as Animals;
            Details clonedDetails = new Details();

            clonedDetails.Color = this.Caracteristics.Color;
            clonedDetails.ScientificName = this.Caracteristics.ScientificName;

            cloned.Caracteristics = clonedDetails;

            return cloned;
        }
    }
    public class Details 
    { 
        public string Color { get; set; }
        public string ScientificName { get; set; }
    }
}
