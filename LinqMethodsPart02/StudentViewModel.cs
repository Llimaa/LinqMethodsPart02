namespace LinqMethodsPart02
{
    public class StudentViewModel
    {
        public StudentViewModel(string name, string documento)
        {
            Name = name;
            Documento = documento;
        }

        public string Name { get; set; }
        public string Documento { get; set; }
    }
}
