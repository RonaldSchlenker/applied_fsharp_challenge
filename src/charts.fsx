
#load "chart_helper.fsx"

open Chart_helper
open System
open XPlot.Plotly

module Data =
    
    let rnd = Random()
    let length = 20
    
    let noise = [
        for i in 0..length do
        yield rnd.NextDouble()
    ]

    let sin = [
        for i in 0..length ->
        Math.Sin (float i / 1.06) * 0.5
    ]

    let jump =
        let init v = List.init (length/2) (fun _ -> v) 
        init 0.0 @ init 1.0

    let rect =
        jump @ jump @ jump @ jump @ jump @ jump


chart "0 - Input" Data.sin |> show
