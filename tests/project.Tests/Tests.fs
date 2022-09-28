namespace MathMech_lessons.Tests

open Expecto
open MathMech_lessons.Main

module SayTests =
    [<Tests>]
    let tests =
        testList
            "samples"
            [ testCase "Test for sum"
              <| fun _ ->
                  let actualResult = f1 2 10

                  Expect.equal actualResult 1024 "The answer isn't correct" ]
