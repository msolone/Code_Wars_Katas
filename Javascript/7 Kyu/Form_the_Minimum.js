function minValue(values) {
  return parseInt(
    [...new Set(values)]
      .map(n => n.toString())
      .sort()
      .join("")
  );
}
