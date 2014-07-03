
let generation axiom (rules : Map<char, string>) =
    Seq.map (fun (x : char) ->
     match rules.TryFind(x) with
     | Some(t) -> rules.Item(x)
     | None -> x.ToString()
     ) axiom
        
let start = "aabb+x"
let ruleset = 
    Map.empty.Add('a', "b")

let result = generation start ruleset

let print = (String.concat "" result)
    

    