// Complete the method/function so that it converts dash/underscore delimited words into camel casing.
// The first word within the output should be capitalized only if the original word was capitalized.

// Examples
// toCamelCase("the-stealth-warrior") // returns "theStealthWarrior"

// toCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior"

function toCamelCase(str) {
    let answer = [];
    if (str.includes("-")) {
      let strArr = str.split("-");
      for (let i = 0; i < strArr.length; i++) {
        let word = strArr[i];
        if (i === 0) {
          answer.push(strArr[i]);
        } else {
          let capWord = word[0].toUpperCase() + word.slice(1);
          answer.push(capWord);
        }
      }
      return answer.join("");
    } else {
      let strArr = str.split("_");
      for (let i = 0; i < strArr.length; i++) {
        let word = strArr[i];
        if (i === 0) {
          answer.push(strArr[i]);
        } else {
          let capWord = word[0].toUpperCase() + word.slice(1);
          answer.push(capWord);
        }
      }
      return answer.join("");
    }
  }
