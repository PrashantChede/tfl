
using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var emp=new {

Id=11,FirstName="chaitanya",LastName="walke"

};

List<Employee> employees= new List<Employee>();

employees.Add(new Employee(){Id=22,FirstName="abc",LastName="def"});
employees.Add(new Employee(){Id=33,FirstName="ghi",LastName="jkl"});
employees.Add(new Employee(){Id=44,FirstName="mno",LastName="pqr"});

app.MapGet("/", () => "Welcome to IACSD !!");
app.MapGet("/anno",()=> emp);
app.MapGet("/employees",()=>employees);

app.Run();

