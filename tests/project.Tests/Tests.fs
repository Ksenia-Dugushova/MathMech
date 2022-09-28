namespace MathMech_lessons.Tests

open Expecto
open MathMech_lessons

module SayTests =
    [<Tests>]
    let tests =
        testList
            "samples"
            [ testCase "Test for sum"
              <| fun _ ->
                  let actualResult = sum 10 0
                  Expect.equal actualResult 55 "Sum from 10 to 0 should be 55"]

             
