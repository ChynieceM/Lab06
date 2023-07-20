namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rhino rhino = new Rhino();
            rhino.Charge();
            
            Monkey monkey = new Monkey();
            monkey.Walk();
            monkey.Sleep();
            monkey.ClimbTree();
           
            CommodoDragon commodoDragon = new CommodoDragon();
            commodoDragon.Sound();
            commodoDragon.Eat();

            Eagle eagle = new Eagle();
            eagle.Fly();

            GekkoLizard gekkoLizard = new GekkoLizard();
            gekkoLizard.Eat();
            gekkoLizard.Sound();


        }
    }
}