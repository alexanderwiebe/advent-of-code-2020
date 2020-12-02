namespace services

open System

module Day02 =
    let parsePassword (passwordConfig:string) : string [] = passwordConfig.Split(" ")