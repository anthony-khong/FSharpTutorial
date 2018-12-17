#load "packages/MathNet.Numerics.FSharp/MathNet.Numerics.fsx"

open MathNet.Numerics

SpecialFunctions.Gamma(0.5)

open MathNet.Numerics.LinearAlgebra
let m : Matrix<float> = DenseMatrix.randomStandard 50 50
(m * m.Transpose()).Determinant()

m.D

open MathNet.Numerics.LinearAlgebra
let xs: Matrix<float> = DenseMatrix.randomStandard 50 50
let ys: Vector<float> = DenseVector.randomStandard 50

(xs * ys).S

xs.ToTypeString()


