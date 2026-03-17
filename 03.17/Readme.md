# Nəqliyyat Sistemi

1. Bir `Vehicle` class-ı yaradın. Class daxilində aşağıdakı property-ləri yaradın:
	- Brand (encapsulation ilə minimum 3 simvol olmalıdır)
	- Model 
	- Year (encapsulation ilə 1900-dən böyük olmalıdır)
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
		Brand: Toyota
		Model: Corolla
		Year: 2018
		Mileage: 120000 km
		Running: Yes
		```

4. `Vehicle`-dan miras alan `Car` class-ı yaradın.
	- Əlavə property-lər:
		- FuelCapacity (encapsulation ilə müsbət olmalıdır)
		- Fuel (encapsulation ilə müsbət olmalıdır)
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

	- `VehicleInfo()` method-un override edin və əlavə olaraq `Fuel` sətri də çıxsın:
		```
		Fuel: 20.0L / 50.0L
		```