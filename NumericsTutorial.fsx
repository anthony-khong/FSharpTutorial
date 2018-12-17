load "packages/MathNet.Numerics.FSharp/MathNet.Numerics.fsx"

open MathNet.Numerics

SpecialFunctions.Gamma(0.5)

open MathNet.Numerics.LinearAlgebra
let m : Matrix<float> = DenseMatrix.randomStandard 50 50
(m * m.Transpose()).Determinant()

m.D

open MathNet.Numerics.LinearAlgebra
let xs: Matrix<float> = DenseMatrix.randomStandard 50 50
let ys: Vector<float> = DenseVector.randomStandard 50

(xs * ys)

xs.ToTypeString()

open MathNet.Numerics.Distributions
open MathNet.Numerics.Statistics

let phi x = 
    let normal = new Normal()
    normal.CumulativeDistribution(x)

phi 1.96

(new Normal()).CumulativeDistribution(1.96)

DenseMatrix.random<float> 3 4 (Gamma(1.0, 2.0))

DenseMatrix.zero<float> 10 20 |> Statistics.quantileFunc

(new Normal()).Sample()

(float 1)

seq { for x in 1 .. 100 do
      if x % 3 = 0 then yield x*x }

let xs = ['a' .. 'f']
let ys = List.mapi (fun i x -> x.ToString() + i.ToString()) xs
