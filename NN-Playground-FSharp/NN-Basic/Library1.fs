

namespace NN_Basic

type Class1() = 
    member this.X = "F#"

module ActivationFunctions =

    let logSigmoidFunction potential lambda =
        1.0 / (1.0 + System.Math.Exp(lambda * potential))


module HelperFunctions =

    let computePotential (weights:double list) (input:double list) : double = 
        List.fold2 (fun acc x y -> acc + x * y) 0.0 weights input 