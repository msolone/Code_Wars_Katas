function points(games) {
    let total = 0
    games.map(game => {
        arr = game.split(":")
        if (arr[0] > arr[1]) {
            total += 3
        } else if (arr[0] === arr[1]) {
            total += 1
        }
        
    })
    return total;
  }