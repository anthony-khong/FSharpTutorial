#load "packages/FsLab/FsLab.fsx"

open FsLab
open Deedle
open FSharp.Data

let wb = WorldBankData.GetDataContext()
let cz = wb.Countries.``Czech Republic``.Indicators
let eu = wb.Countries.``European Union``.Indicators

let czschool = series cz.``School enrollment, tertiary (% gross)``
let euschool = series eu.``School enrollment, tertiary (% gross)``
abs (czschool - euschool)
|> Series.sort
|> Series.rev
|> Series.take 5
