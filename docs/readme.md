#to run code ```
 dotnet run main.cs ```


#To start the agent ```
Get-Service -Name ssh-agent | Set-Service -StartupType Manual
Start-Service ssh-agent
Get-Service ssh-agent ```


# add key to ssh agent 
``` ssh-add C:/Users/Madhumithabalu/.ssh/id_ed25519```

# C# OOP Learning

## 📚 OOP Learning Progress


### Day 1 — Abstraction

**Main Topic:** Abstraction

**Subtopics Learned:**

* Abstract Class
* Abstract Method
* Interface
* Virtual Method
* Method Overriding
* Interface Implementation
* Hiding Implementation Details

**Practice:**

Created different payment implementations.

```text
IPayment
   ↓
CreditCardPayment


Payment
   ↓
UPIPayment
```

Used an interface for `CreditCardPayment` and an abstract class for `UPIPayment`.

**File:** `abstraction.cs`

---

### Day 2 — Encapsulation

**Main Topic:** Encapsulation

**Subtopics Learned:**

* Data Hiding
* Private Fields
* Public Methods
* Controlled Access
* Getter Method
* Protecting Object Data

**Practice:**

Created a `BankAccount` class where the `balance` field is private.

```text
BankAccount
    ↓
private balance
    ↓
deposite()
withdrawal()
getbalance()
```

The `balance` cannot be accessed directly from outside the class. It is accessed through public methods.

**File:** `encap.cs`

---

### Day 3 — Polymorphism

**Main Topic:** Polymorphism

**Subtopics Learned:**

* Compile-Time Polymorphism
* Runtime Polymorphism
* Interface-Based Polymorphism
* Multiple Implementations
* Method Overloading
* Method Overriding

**Practice:**

Created different notification classes:

```text
INotification
      ↓
 ┌────┼─────────────────┐
 ↓    ↓                 ↓
Email SMS           Instagram
```

The same `NotificationService.send()` method can work with different notification implementations.

Example:

```csharp
service.send(new EmailNotification());
service.send(new SMSNotification());
service.send(new InstagramNotification());
```

**File:** `polymorphism.cs`

---

### Day 4 — Inheritance

**Main Topic:** Inheritance

**Subtopics Learned:**

* Base Class
* Derived Class
* Single Inheritance
* Code Reusability
* Constructor
* Base Class Constructor
* `base` Keyword
* Parent-Child Relationship

**Practice:**

Created an `Employee` base class and derived `Developer` and `Manager` classes from it.

```text
                 Employee
                    |
           ┌────────┴────────┐
           ↓                 ↓
       Developer          Manager
           |                 |
      writeCode()       manageMeeting()
```

Both `Developer` and `Manager` inherit:

```text
Id
Name
Email
Department
PhoneNo
login()
```

The derived-class constructors use the `base()` keyword to call the constructor of the `Employee` base class.

Example:

```csharp
public class Developer : Employee
{
    public Developer(
        int id,
        string name,
        string email,
        string department,
        int phoneNo)
        : base(id, name, email, department, phoneNo)
    {
    }
}
```

**File:** `inheritance.cs`

---

# 🧠 Four Pillars of OOP

| OOP Concept   | What I Learned                                  |
| ------------- | ----------------------------------------------- |
| Encapsulation | Protecting and controlling access to data       |
| Abstraction   | Hiding implementation details                   |
| Inheritance   | Reusing functionality from a base class         |
| Polymorphism  | One interface/base type with multiple behaviors |

---


# ▶️ Run the Project

Go to the project folder:

```powershell
cd "D:\Demo project\MyApp"
```

Run the application:

```powershell
dotnet run
```

Build the project:

```powershell
dotnet build
```

---

# 🔧 Git Commands

Check repository status:

```powershell
git status
```

Add changes:

```powershell
git add .
```

Commit changes:

```powershell
git commit -m "Learn inheritance in C#"
```

Push changes:

```powershell
git push
```

View commit history:

```powershell
git log --oneline
```

Check remote repository:

```powershell
git remote -v
```

---


**Learning → Practicing → Understanding → Building**

DAY 1 → Encapsulation
         ├── Data Hiding
         ├── Private Fields
         ├── Public Methods
         └── Controlled Access

DAY 2 → Abstraction
         ├── Abstract Class
         ├── Abstract Method
         ├── Interface
         ├── Virtual Method
         └── Method Overriding

DAY 3 → Polymorphism
         ├── Compile-time Polymorphism
         ├── Runtime Polymorphism
         ├── Interface-based Polymorphism
         └── Multiple Implementations

DAY 4 → Inheritance
         ├── Base Class
         ├── Derived Class
         ├── Single Inheritance
         ├── Code Reusability
         ├── Constructor
         ├── base Keyword
         └── Calling Base Constructor