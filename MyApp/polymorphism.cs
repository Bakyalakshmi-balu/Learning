namespace MyApp{ 

// compile time polymorphism
// class Shape with two overloaded methods to calculate area
    // public class Shape{
    //     public double Area(double side){
    //     return side*side;
    // }

    // public double Area(double length, double width){
    //     return length*width;
    // }
    // }


// runtime polymorphism
// interface Inotification with a method to send notification
    public interface Inotification{
        void sendNotification(string message);
    }

// classes that implement the Inotification interface and provide their own implementation of the sendNotification method
    public class EmailNotification : Inotification{
        public void sendNotification(string message){
            Console.WriteLine("Email sent: " + message);
        }

    }

    public class SMSNotification :Inotification{
        public void sendNotification(string message){
            Console.WriteLine("SMS sent: " + message);
        }
    }

    public class InstagramNotification :Inotification{
        public void sendNotification(string message){
            Console.WriteLine("Instagram sent: " + message);
        }
    }

    // NotificationService class that uses the Inotification interface to send notifications

    public class NotificationService{
        public void send( Inotification notification){
            notification.sendNotification("your account credited with 1000");   
    }
}
}