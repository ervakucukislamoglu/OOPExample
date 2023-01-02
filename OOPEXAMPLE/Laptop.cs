using System;

public abstract class Laptop
{
    //aşağıdaki virtual metod. virtual metod der ki beni kim inherit alırsa olduğum gibi kullanabilir yada override edebilir.
    //yani virtual kelimesi der ki bu concretely tanımlanmış metodu alabilirsin ve onu override etme hakkın var.
    public virtual void TurnOn()
    {
        Console.WriteLine("Turning on.");
    }
    //aşağıdaki metod concretely define edilmiş. Concrete abstract olamayan şeylere denir.
    //concrete method or behavior der ki Laptop classından inherit alan her şey bu metoda default olarak sahip olacak ve kullanabilecektir.
    public void TurnOff()
    {
        Console.WriteLine("Turning off.");
    }

    //Her laptop aynı şekilde kapanır ancak hepsi aynı şekilde açılmak zorunda değil, aynı da olabilir farklı da olabilir.
    //Bu yüzden açılma metodunu virtual yaratıp inherit alan sınıflarda override edilebilme şansı tanıdık.
   
   //aşağıdaki abstract property, Laptop classından inherit alan classlarda özellikle tanımlanmak zorundadır.
   //Çünkü abstract classta define edilmemiştir. Bu yüzden abstract classtan miras alan her sınıfta define edilmelidir.
   public abstract bool TouchScreen {get;}
}