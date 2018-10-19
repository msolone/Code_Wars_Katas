// My Answer
function inArray(array1, array2) {
  let r = [];
  for (let i = 0; i < array1.length; i++) {
    for (let j = 0; j < array2.length; j++) {
      if (!r.includes(array1[i])) {
        if (array2[j].includes(array1[i])) {
          r.push(array1[i]);
        }
      }
    }
  }
  console.log(r);
  return r;
}

// Top Answer
// function inArray(array1,array2){
//     return array1
//       .filter(a1 => array2.find(a2 => a2.match(a1)))
//       .sort()
//   }