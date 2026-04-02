using _04._01.iNTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
//ICargoService interfeysi: Özündə statik olaraq Customer, Courier və CargoOrder massivləri saxlayacaq
//AddCustomer(): Bir Customer qəbul edib müştəri listinə əlavə edəcək.
//AddCourier(): Bir Courier qəbul edib müştəri listinə əlavə edəcək.
//CreateOrder(): Buraya gələcək olan CargoOrder obyekti daxilində olan - CustomerId və CourierId dəyərləri yoxlanılacaq ki, bu dəyərlərə uyğun məlumat varmı (əgər tapılmasa exception göndərilsin). Əgər hər ikisi varsa daha sonra tapılan kuryerin sifarişə uyğun olub olmaması yoxlanılacaq yəni onun IsAvialable propertisi. Əgər kuryer sifarişə uyğun olmasa Exception atılacaq (custom yaratmağınız daha yaxşı olar). Əgər uyğundursa onu qeyd edəcək və həmin kuryer artıq sifariş qəbul edə bilməyəcək.
//CompleteOrder(): id qəbul edəcək. Həmin id-də order yoxdursa xəta verəcək. Əgər varsa, həmin order-i artıq tamamlanmış olaraq (Delivered) qeyd edəcək. Həmçinin həmin sifariş üçün ayrılmış olan kuryeri artıq yeni sifariş qəbul etməyə uyğun formata gətirəcək.

namespace _04._01.iNTERFACES;

internal interface ICargoService
{
    void AddCustomer(Customer newCustomer);
    void AddCourier(Courier newCourier);
    void CreateOrder(CargoOrrder newCargo);
    void CompleteOrder(int Id);


}
