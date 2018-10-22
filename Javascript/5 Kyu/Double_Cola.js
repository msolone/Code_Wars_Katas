function whoIsNext(names, r) {
  if (r === 1) {
    return names[0];
  } else {
    for (let i = 1; i <= r; i++) {
      names.push(names[0]);
      names.push(names[0]);
      names.shift();
    }
  }
  console.log(names);
  return names[0];
}

function whoIsNext(names, r) {
console.log(r)
  let next = "";
  for (let i = 1; i < r; i++) {
    names.push[names[i]];
    names.push[names[i]];
    next = names[i + 1];
  }
  if (r === 1) {
    return names[0];
  } else {
    console.log(next);
    return next;
  }
}
