
# Inheritance Tapşırığı — Nəqliyyat Sistemi

1. Bir `Vehicle` base class-ı yaradın. Class daxilində aşağıdakı property-ləri yaradın:
	- Brand
	- Model
	- Year
	- MileageKm
	- IsRunning

2. `Vehicle` constructor aşağıdakı məlumatları qəbul etməlidir:
	- Brand
	- Model
	- Year

3. `Vehicle` class daxilində aşağıdakı method-ları yaradın:
	- `StartEngine()`
		Mühərriki işə salır (`IsRunning = true`).

	- `StopEngine()`
		Mühərriki söndürür (`IsRunning = false`).

	- `Drive(int km)` (virtual)
		Əgər mühərrik işləyirsə, avtomobili sürür və `MileageKm` artırır. Əgər `IsRunning` false-dursa, sürüş mümkün deyil və uyğun mesaj göstərilməlidir.

	- `VehicleInfo()` (virtual)
		Nəqliyyat vasitəsi haqqında məlumat göstərir.
		Məlumat aşağıdakı formatda göstərilməlidir:
		```
		Type: Vehicle
		Brand: Toyota
		Model: Corolla
		Year: 2018
		Mileage: 120000 km
		Running: Yes
		```

4. `Vehicle`-dan miras alan `Car` class-ı yaradın.
	- Əlavə property-lər:
		- FuelCapacity
		- Fuel
		- FuelConsumptionPer100Km (məsələn 7.5)

	- Constructor aşağıdakı məlumatları qəbul etməlidir:
		- Brand
		- Model
		- Year
		- FuelCapacity
		- FuelConsumptionPer100Km
		- Fuel

		Qaydalar:
		```text
		Fuel <= FuelCapacity
		```

	- `Refuel(double liters)`
		Yanacaq doldurur.

		Şərt:
		```text
		Fuel + liters <= FuelCapacity
		```

	- `Drive(int km)` method-un override edin.
		Sürüş zamanı yanacaq sərf olunmalıdır.

		Sərf:
		```text
		requiredLiters = (km / 100.0) * FuelConsumptionPer100Km
		```

		Əlavə şərt:
		```text
		Fuel >= requiredLiters
		```

	- `VehicleInfo()` method-un override edin və `Type` sətrini `Car` göstərin, əlavə olaraq `Fuel` sətri də çıxsın:
		```
		Fuel: 20.0L / 50.0L
		```

5. `Vehicle`-dan miras alan `ElectricCar` class-ı yaradın.
	- Əlavə property-lər:
		- BatteryCapacity
		- Battery
		- ConsumptionKWhPer100Km (məsələn 15)

	- Constructor aşağıdakı məlumatları qəbul etməlidir:
		- Brand
		- Model
		- Year
		- BatteryCapacity
		- ConsumptionKWhPer100Km
		- Battery

		Qaydalar:
		```text
		0 <= Battery <= BatteryCapacity
		```

	- `Charge(double kwh)`
		Batareyanı doldurur.

		Şərt:
		```text
		Battery + kwh <= BatteryCapacity
		```

	- `Drive(int km)` method-un override edin.
		Sürüş zamanı enerji sərf olunmalıdır.

		Sərf:
		```text
		requiredKWh = (km / 100.0) * ConsumptionKWhPer100Km
		```

		Əlavə şərt:
		```text
		Battery >= requiredKWh
		```

	- `VehicleInfo()` method-un override edin və `Type` sətrini `ElectricCar` göstərin, əlavə olaraq `Battery` sətri də çıxsın:
		```
		Battery: 30.0kWh / 60.0kWh
		```

6. `Program.cs` daxilində aşağıdakıları edin:
	- Həm `Car`, həm də `ElectricCar` üçün obyekt yaradın.
	- Derived ctor-larda `base(...)` constructor çağırışından istifadə edin.
	- Ən azı 1 dəfə `Drive` method-un polymorphism ilə çağırın:
		```csharp
		Vehicle v = new ElectricCar(...);
		v.StartEngine();
		v.Drive(120);
		```
	- `StartEngine/StopEngine`, `Drive`, `Refuel/Charge`, `VehicleInfo` çağırışlarını test edin.
