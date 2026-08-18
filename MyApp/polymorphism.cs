namespace MyApp{ 

    //public class Shape{
    //     public double Area(double side){
    //     return side*side;
    // }

    // public double Area(double length, double width){
    //     return length*width;
    // }
    //}

    public interface Inotification{
        void sendNotification(string message);
    }

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

    public class NotificationService{
        public void send( Inotification notification){
            notification.sendNotification("your account credited with 1000");   
    }
}
}