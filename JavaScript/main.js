//task 1
//. Write JS code asking for your name and printing it.

function getInputValueNames() {
    // Selecting the input element and get its value 
    var inputVal = document.getElementById("myInputNames").value;

    // Displaying the value
    alert('Your fullName is: ' + inputVal);
}

//  task 2 //
//Write JS code that prints the numbers 2, 202 and 2002.


function typeThreeNums() {
    let inputThreeNumsValue = document.getElementById("myInputNums").value;
    alert('the three numbers are : ' + inputThreeNumsValue);
}

//Task 3
//Write JS code that prints the current date and time.

function printTodayDate() {
    let date = new Date().toLocaleString();
    alert('Today is : ' + date);
}

//Task 4 
function SquareRootOf32346() {
    let x = Math.sqrt(32346);
    alert('Square Root of number 32346 is: ' + x);
}

// Task 5
// Declare two integer variables and assign them with 5 and 10 and after that exchange
// their values.

function PrintExchangedValues() {
    let firstNum = document.getElementById("myFirstNum").value; // 5
    let secNum = document.getElementById("mySecNum").value; // 10

    let thirdNum = firstNum;  //5

    firstNum = secNum;  // 10   
    secNum = thirdNum; 5                     // 10            // 5
    alert("The new exchanged values are :" + firstNum + ' and ' + secNum);
}


/// Operators and Conditions/ JS Tasks /
// Task 1 -> 1. Write an expression that checks if given integer is odd or even.

function IsNumberEvenOrOdd() {
    let number = document.getElementById('myInputNum').value;
    number % 2 == 0 ? alert('The number ' + number + ' is even') : alert('The number: ' + number + ' is odd');
}


// task 2 -> 2. Write an expression that calculates rectangle’s area by given width and height
function CalculateSquareArea() {
    let number1 = document.getElementById('myInputNum1').value;
    let number2 = document.getElementById('myInputNum2').value;
    let result = number1 * number2;
    alert('The Area is: ' + result);

}

// Task 3 -> 
//3. Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
// E.g. 37 is prime.

function isPrime() {
    let num = document.getElementById('myInputNum3').value;

    if (num <= 1) {
        return alert(false);
    } else {
        for (var i = 2; i < num; i++) {
            if (num % i === 0) {
                return alert(false);;
            }
        }
        return alert(true);
    }
}


///
/// : No, a JS function needn't return anything as far as your code goes.
/// So to recap: No, a JS function needn't return anything as far as your code goes.
// But as far as the JS engines are concerned: a function always returns something, be it explicitly via a return statement, or implicitly. 
//If a function returns implicitly, its return value will always be undefined.
///


// Task 4:
//4. Write an expression that calculates trapezoid's area by given sides a and b and height
//h.



function calcAreaOfTrapezoid() {
    let a = parseInt(document.getElementById('myInputSideA').value);
    let b = parseInt(document.getElementById('myInputSideB').value);
    let h = parseInt(document.getElementById('myInputSideH').value);

    let SquareArea = ((a + b) / 2) * h;
    // return alert(`The trapezoid SquareArea is: ` + `${SquareArea}`); - >string interpolation way to show the result
    return alert(`The trapezoid SquareArea is: ` + SquareArea);
}


///
/// Task 5

// Write an IF statement that examines two integer variables and exchanges their values
// if the first one is greater than the second one.

function exchangeValuesIfAGreaterThanB() {
    let a = parseInt(document.getElementById('numA').value);
    let b = parseInt(document.getElementById('numB').value);

    if (a > b) {
        let c = b;
        b = a;
        a = c;
        alert(a + ' and ' + b);
    }
}


//Task 6

//Write a program that shows the sign of the product of three real numbers without
//calculating it. Use a sequence of if statements.

function showSignOfProductOf3Nums() {

    let aNum = parseInt(document.getElementById('num_a').value);
    let bNum = parseInt(document.getElementById('num_b').value);
    let cNum = parseInt(document.getElementById('num_c').value);

    if (aNum == 0 || bNum == 0 || cNum == 0) {
        alert('Product is 0 and  0 has no sign');        // 0 || 0 || 0
    } else if (aNum < 0 && bNum < 0 && cNum < 0) {         //  <  <  <        
        alert('Product is negative');
    } else if (aNum < 0 && bNum > 0 && cNum > 0) {          // <  >  >
        alert('Product is negative');
    } else if (aNum < 0 && b < 0 && c > 0) {               //  <  <  >
        alert('Product is negative');
    } else if (aNum > 0 && bNum > 0 && cNum > 0) {         // >  >  >
        alert('Product is positive');
    } else if (aNum > 0 && bNum < 0 && cNum > 0) {         // >  <  >
        alert('Product is negative');
    } else if (aNum > 0 && bNum > 0 && cNum < 0) {        // >  >  <
        alert('Product is negative');
    } else if (aNum > 0 && bNum < 0 && cNum < 0) {       // >  <  < 
        alert('Product is negative');
    } else if (aNum < 0 && bNum > 0 && c < 0) {          // <  >  < 
        alert('Product is negative');
    }
}

/// Collections and Loops in JS 
// Task 1  // 1. Write JS code that prints all the numbers from 1 to 30.

function PrintArrayFromRange() {

    let start = parseInt(document.getElementById('num_x').value);
    let end = parseInt(document.getElementById('num_y').value);
    let output = [];

    if (start > end) {
        alert('start number must be lower than the endNumber');
        return;
    } else if (start == end) {
        alert(start);
        return;
    }

    for (var i = start; i <= end; i++) {
        output.push(i);
    }

    alert(output.toString());    // return output;      

};

// Task 2 
//2. Write JS code that prints all the numbers from 1 to 30, that are not divisible by 3 and 7
//at the same time.

function PrintAllNotDevisibleNumsOf3And7FromArray(){
    let start = parseInt(document.getElementById('num_').value);
    let end = parseInt(document.getElementById('numA_').value);
    let outputA = [];

    if (start > end) {
        alert('start number must be lower than the endNumber');
        return;
    } else if (start == end) {
        alert(start);
        return;
    }

    for (let i = start; i <= end; i++) {
        outputA.push(i);
    }

    //alert(outputA.toString());   
    const newArray = outputA.filter( n => n % 3 != 0 && n % 7 != 0);
    alert(newArray.toString());    // return output; 
}

///
// Task 3.
// 3. Write JS code that allocates array of 20 integers and initializes each element by its
// index multiplied by 5. Print the obtained array on the console.

function Print20NumbersFromArray(){
   let start = parseInt(document.getElementById('startNum').value);
   let end = parseInt(start + 19);

   const outputArray = [];
   for(let i = start; i <= end; i++){
      outputArray.push(i * 5);      
   }
  
   alert(outputArray.toString() + "\n " + "The array length is: " + outputArray.length)    

}

// Task 1 Functions

function getMax(a, b){
    let firstNum = a;
    let secNum = b ;

    if(firstNum > secNum){
         return firstNum;
    }else if(secNum > firstNum) {
        return secNum;
    }
}







 




