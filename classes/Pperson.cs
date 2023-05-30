namespace Classes;
public class Person{
    private string FirstName {
        get;
    }
    private string LastName {
        get;
    }
    private int age {
        get ;
    }
    public Person(string firstName,string lastName,int age){
      this.FirstName = firstName;  
      this.LastName = lastName;
      this.age = age;

    }
}