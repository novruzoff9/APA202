# İşçi İdarəetmə Sistemi

1. `Employee` adında class yaradılacaq:
    - `Id` (statik olaraq artacaq)
    - `Name`
    - `Surname`
    - `Department` (enum olacaq, aşağıda verilib)
    - `Salary`
    - `HireDate`

2. Enum:
    - `Department`: `HR`, `IT`, `Finance`, `Marketing`, `Operations`

3. Servis: `EmployeeService`
    - Daxildə statik `List<Employee>` saxlasın
    - `Add(Employee employee)` -> işçi əlavə et. Eyni `Name + Surname` ilə işçi əlavə olunarsa `Exception` atılsın
    - `GetById(int id)` -> id-yə görə işçi qaytar. İşçi tapılmasa `Exception` atılsın
    - `GetAll()` -> bütün işçiləri qaytar
    - `GetByDepartment(Department department)` -> departamentə görə filter
    - `GetMostExpensiveEmployee()` -> ən yüksək maaşlı işçi
    - `GetCheapestEmployee()` -> ən az maaşlı işçi
    - `GetAverageSalary()` -> orta maaş
    - `CountByDepartment(Department department)` -> departamentə görə say
    - `GetBySalaryRange(double min, double max)` -> maaşa aralığına görə filter
    - `UpdateSalary(int id, double newSalary)` -> İşçinin maaşını artır
    - `UpdateAllSalaries(double percentage)` -> Bütün işçilərin maaşını fazile artır
    - `Remove(int id)` -> id-yə görə işçi sil

4. Məlumatlar `data.json` adlı faylda saxlanacaq və proqram başladıqda bu fayldan yüklənəcək, proqram bitdikdə isə yenilənmiş məlumatlar bu fayla yazılacaq.
