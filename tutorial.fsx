open System

let randint (low: int) (high: int) count =
    let random = System.Random() 
    let nUniques = high - low
    List.init count (fun _ -> (random.Next () % (nUniques + 1) + low))

let testAllWithinRange =
	[1..100] 
    |> List.map (randint 0 100) 
    |> List.forall (List.forall (fun x -> (0 <= x) && (x <= 100)))

let testAtLeastOneInBoundary =
    let (low, high) = (-1, 3)
    let nSims = 1000
    let xs = randint low high nSims
    (List.contains low xs) && (List.contains high xs)
