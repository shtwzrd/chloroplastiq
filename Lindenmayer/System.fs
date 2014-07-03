namespace Lindenmayer

module private Helper =
    let toMap (dictionary) =
           (dictionary :> seq<_>)
           |> Seq.map (|KeyValue|)
           |> Map.ofSeq

module System =

    let private gen (axiom : string) (rules : Map<char, string>) =
        Seq.map (fun (x : char) ->
        match rules.TryFind(x) with
        | Some(t) -> rules.Item(x)
        | None -> x.ToString()
        ) axiom

    let generation (axiom : string) rules  =
        let ruleSet = Helper.toMap(rules)
        let grammar = 
            gen axiom ruleSet
            |> String.concat ""
        grammar
