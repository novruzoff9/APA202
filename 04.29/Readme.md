# Lab 10 - 25 İyul
## JavaScript ilə Alqoritmlər

### 📅 Keçilmiş Mövzular
- **Conditional Statements:** if/else, switch/case
- **Loops:** for, while, do-while
- **Arrays:** array yaratma, elementlərə müraciət, array metodları
- **Objects:** obyekt yaratma, property-lərə müraciət
- **Array Methods:** push(), pop(), shift(), unshift(), slice(), splice(), etc.
- **String Methods:** charAt(), substring(), indexOf(), split(), etc.

---

## 🎯 Tapşırıqlar Səviyyələrə Görə

### 🟢 SADƏ SEVİYYƏ (If/Else, Loops, Basic Arrays)

#### **1. Conditional Statements**
```javascript
// 1.1 - Rəqəmin müsbət, mənfi və ya sıfır olduğunu yoxlayın
function checkNumber(num) {
    // Kodunuzu buraya yazın
}

// 1.2 - Yaşa görə kateqoriya təyin edin (uşaq: 0-12, yeniyetmə: 13-19, böyük: 20+)
function ageCategory(age) {
    // Kodunuzu buraya yazın
}

// 1.3 - Switch-case ilə həftənin günlərini qaytarın (1-7 arası rəqəm)
function getDayName(dayNumber) {
    // Kodunuzu buraya yazın
}
```

#### **2. Basic Loops**
```javascript
// 2.1 - 1-dən 100-ə qədər cüt ədədləri çap edin
function printEvenNumbers() {
    // Kodunuzu buraya yazın
}

// 2.2 - Ədədin faktorialını hesablayın
function factorial(n) {
    // Kodunuzu buraya yazın
}

// 2.3 - Fibonacci seriyasının ilk n elementini qaytarın
function fibonacci(n) {
    // Kodunuzu buraya yazın
}

// 2.4 - Ədədin rəqəmlərinin cəmini hesablayın
function digitSum(num) {
    // Kodunuzu buraya yazın
}
```

#### **3. Basic Arrays**
```javascript
// 3.1 - Array-in elementlərinin cəmini hesablayın
function sumArray(arr) {
    // Kodunuzu buraya yazın
}

// 3.2 - Array-də müəyyən element olub-olmadığını yoxlayın
function containsElement(arr, element) {
    // Kodunuzu buraya yazın
}

// 3.3 - Array-i tərsinə çevirin
function reverseArray(arr) {
    // Kodunuzu buraya yazın
}

// 3.4 - İki array-i birləşdirin
function mergeArrays(arr1, arr2) {
    // Kodunuzu buraya yazın
}
```

---

### 🟡 ORTA SEVİYYƏ (Array Methods, Objects, String Methods)

#### **4. Array Methods**
```javascript
// 4.1 - Array-dən cüt ədədləri filter() ilə çıxarın
function getEvenNumbers(arr) {
    // Kodunuzu buraya yazın
}

// 4.2 - Array-in hər elementini map() ilə 2-yə vurun
function doubleNumbers(arr) {
    // Kodunuzu buraya yazın
}

// 4.3 - Array-də some() ilə mənfi ədəd olub-olmadığını yoxlayın
function hasNegativeNumber(arr) {
    // Kodunuzu buraya yazın
}

// 4.4 - Array-də find() ilə ilk cüt ədədi tapın
function findFirstEven(arr) {
    // Kodunuzu buraya yazın
}

// 4.5 - Array-i sort() ilə azalan sırada düzün
function sortDescending(arr) {
    // Kodunuzu buraya yazın
}
```

#### **5. String Methods & Advanced**
```javascript
// 5.1 - String-də sözlərin sayını hesablayın
function wordCount(str) {
    // Kodunuzu buraya yazın
}

// 5.2 - String-də hər hərfin neçə dəfə təkrarlandığını sayın
function letterFrequency(str) {
    // Kodunuzu buraya yazın
}

// 5.3 - Palindrom olub-olmadığını yoxlayın
function isPalindrome(str) {
    // Kodunuzu buraya yazın
}

// 5.4 - String-i camelCase-ə çevirin
function toCamelCase(str) {
    // Kodunuzu buraya yazın
}

// 5.5 - String-də ən uzun sözü tapın
function longestWord(str) {
    // Kodunuzu buraya yazın
}
```

#### **6. Objects**
```javascript
// 6.1 - Tələbə obyektini yaradın və qiymət əlavə etmək üçün metod yazın
function createStudent(name, age) {
    // Kodunuzu buraya yazın
}

// 6.2 - Avtomobil obyekti yaradın və məlumatları göstərən metod əlavə edin
function createCar(brand, model, year) {
    // Kodunuzu buraya yazın
}

// 6.3 - İki obyekti müqayisə edən funksiya yazın
function compareObjects(obj1, obj2) {
    // Kodunuzu buraya yazın
}

// 6.4 - Obyektin property-lərini array halında qaytarın
function getObjectKeys(obj) {
    // Kodunuzu buraya yazın
}

// 6.5 - Obyektlərdən ibarət array-də filtr tətbiq edin
function filterStudents(students, minAge) {
    // Kodunuzu buraya yazın
}
```

---

### 🔴 ÇƏTİN SEVİYYƏ (Complex Algorithms, Nested Structures)

#### **7. Complex Array Algorithms**
```javascript
// 7.1 - Array-də duplicate elementləri silin
function removeDuplicates(arr) {
    // Kodunuzu buraya yazın
}

// 7.2 - İki array-in kəsişməsini tapın
function arrayIntersection(arr1, arr2) {
    // Kodunuzu buraya yazın
}

// 7.3 - Array-i chunk halında bölün (n elementlik qruplara)
function chunkArray(arr, size) {
    // Kodunuzu buraya yazın
}

// 7.4 - Array-də ən çox təkrarlanan elementi tapın
function mostFrequent(arr) {
    // Kodunuzu buraya yazın
}
```

#### **8. Advanced String Algorithms**
```javascript
// 8.1 - String-də bütün permutasiyaları tapın
function getPermutations(str) {
    // Kodunuzu buraya yazın
}

// 8.2 - String-də ən uzun palindrom substring-i tapın
function longestPalindrome(str) {
    // Kodunuzu buraya yazın
}

// 8.3 - İki string arasında edit distance hesablayın
function editDistance(str1, str2) {
    // Kodunuzu buraya yazın
}

// 8.4 - String-də pattern matching (KMP alqoritmi)
function patternSearch(text, pattern) {
    // Kodunuzu buraya yazın
}
```

#### **9. Complex Object/Data Structures**
```javascript
// 9.1 - Nested obyektlərdə dərin axtarış
function deepSearch(obj, key) {
    // Kodunuzu buraya yazın
}

// 9.2 - Obyektlərdən ibarət array-də qruplamaq
function groupBy(arr, key) {
    // Kodunuzu buraya yazın
}
```