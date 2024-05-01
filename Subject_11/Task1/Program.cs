using System;
using System.Collections.Generic;

public abstract class MedicalWorker
{
    public string Name { get; set; }
    public string Position { get; set; }

    public MedicalWorker(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public abstract void Display();
}

public class Nurse : MedicalWorker
{
    public int HoursWorked { get; set; }

    public Nurse(string name, int hoursWorked) : base(name, "Nurse")
    {
        HoursWorked = hoursWorked;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Position: {Position}, Hours Worked: {HoursWorked}");
    }
}

public class Doctor : MedicalWorker
{
    public int PatientsSeen { get; set; }

    public Doctor(string name, int patientsSeen) : base(name, "Doctor")
    {
        PatientsSeen = patientsSeen;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Position: {Position}, Patients Seen: {PatientsSeen}");
    }
}

public class Program
{
    public static void Main()
    {
        List<MedicalWorker> workers = new List<MedicalWorker>
        {
            new Nurse("Alice", 40),
            new Doctor("Bob", 20),
            new Nurse("Charlie", 45),
            new Doctor("David", 30),
            new Nurse("Eve", 50)
        };

        foreach (var worker in workers)
        {
            worker.Display();
        }

        Console.ReadLine();
    }
}
