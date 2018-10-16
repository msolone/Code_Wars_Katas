// My Answer 
function isDivisible(int wallLength, int pixelSize){
  return (wallLength % pixelSize == 0) ? true : false;
}

// Top Answer

function isDivisible(int wallLength, int pixelSize){
  return wallLength % pixelSize == 0;
}