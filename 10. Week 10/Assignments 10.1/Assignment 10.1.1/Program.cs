/**Create any user defined class of your choice like Student, Customer etc.
 * Add 3 properties in it (of your choice). 
 * Serialize and deserialize the object of this class by Binary, XML, JSON format.
 */

using System;
using System.Text.Json;
using System.Xml.Serialization;



Student student1 = new Student { Id = 101, Name = "Timothy Eckart", Gpa = 3.85m };

JsonSerialize(student1);
XmlSerialize(student1);
BinarySerialize(student1);

// Serialize and deserialize the Student object using JSON format
static void JsonSerialize(Student student)
{
    //Used JsonSerializer Options to format the output JSON string with indentation for better readability.
    var options = new JsonSerializerOptions { WriteIndented = true };

    string json = JsonSerializer.Serialize(student, options);
    // Save the JSON string to a file named "student.json"
    File.WriteAllText("student.json", json);

    // Read the JSON string from the file and deserialize it back to a Student object
    Student? back = JsonSerializer.Deserialize<Student>(File.ReadAllText("student.json"));
    // Display the deserialized Student object in the console
    Console.WriteLine($"JSON-> {back!.Id} | {back.Name} | {back.Gpa}");
}

// Serialize and deserialize the Student object using XML format
static void XmlSerialize(Student student)
{
    // Create an instance of XmlSerializer for the Student type
    var serializer = new XmlSerializer(typeof(Student));

    // Serialize the Student object to an XML file named "student.xml"
    using (var writer = new StreamWriter("student.xml"))
    {
        serializer.Serialize(writer, student);
    }

    // Deserialize the XML back to a Student object
    Student? back;
    using (var reader = new StreamReader("student.xml"))
    {
        back = (Student?)serializer.Deserialize(reader);
    }

    // Display the deserialized Student object in the console
    Console.WriteLine($"XML-> {back!.Id} | {back.Name} | {back.Gpa}");
}


// Serialize and deserialize the Student object using binary format
static void BinarySerialize(Student student)
{
    // Serialize the Student object to a binary file named "student.bin"
    using (var stream = File.Create("student.bin"))


    // Write the properties of the Student object to the binary file
    using (var writer = new BinaryWriter(stream))
    {
        writer.Write(student.Id);      // Int32
        writer.Write(student.Name);    // string
        writer.Write(student.Gpa);     // decimal
    }

    // Deserialize the binary file back to a Student object
    Student back;
    using (var stream = File.OpenRead("student.bin"))
    using (var reader = new BinaryReader(stream))
    {
        back = new Student
        {
            Id = reader.ReadInt32(),
            Name = reader.ReadString(),
            Gpa = reader.ReadDecimal()   
        };
    }
    // Display the deserialized Student object in the console
    Console.WriteLine($"Binary-> {back.Id} | {back.Name} | {back.Gpa}");
}