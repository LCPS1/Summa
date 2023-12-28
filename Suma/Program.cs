using Suma;

//Basic Testing
List<double> lista = new List<double> { 1, 2, 3,6, 4, 5 };
int n = 2;

Agent container = new Agent ();
container.SetAgent(new AgentB());
Console.WriteLine(container.ShowMedia(lista));
Console.WriteLine(container.ShowStairCase(n));
Console.ReadKey();