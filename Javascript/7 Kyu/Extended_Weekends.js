// If the first day of the month is a Friday, it is likely that the month will have an Extended Weekend.
// That is, it could have five Fridays, five Saturdays and five Sundays.

// In this Kata, you will be given a start year and an end year.
// Your task will be to find months that have extended weekends and return:

// - The first and last month in the range that has an extended weekend
// - The number of months that have extended weekends in the range, inclusive of start year and end year.
// For example:
// solve(2016,2020) = ["Jan","May",5]. The months are: Jan 2016, Jul 2016, Dec 2017, Mar 2019 and May 2020

function solve(a, b){
    extendedMonths = [];
    months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
  
    for (let j = a; j <= b; j++) {
      for (let i = 0; i < 12; i++) {
        let y = new Date(j, i, 1);
        if (y.getDay() === 5 && new Date(j, i+1, 1).getDate() === 31) {
          extendedMonths.push(months[y.getMonth()]);
        
        }
      }
    }
    console.log("first month: " + extendedMonths[0]);
    console.log("last month: " + extendedMonths[extendedMonths.length - 1]);
    
    console.log(extendedMonths.length);
    console.log(extendedMonths);
    
    return [extendedMonths[0], extendedMonths[extendedMonths.length - 1], extendedMonths.length]
  }
