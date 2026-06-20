@Coverage
Feature: CodeGenerator
	In order to ensure that the generator backend produces valid output
	As a contributor
	I want to get notified when there is any deviation from reference output

@Coverage
Scenario: Comparing backend output with reference
	Given I have a binary code generator request "test.zap.bin"
	And my reference output is "test.cs"
	When I invoke zapc-csharp
	Then the generated output must match the reference

@Coverage
Scenario Outline: Invalid binary code generator requests
	Given I have a binary code generator request <bin>
	When I invoke zapc-csharp
	Then the invocation must fail

Examples:
    | bin        |
    | null.bin   |
    | test.cs    |

@Coverage
Scenario: Combining frontend and backend
	Given zap.exe is installed on my system
	And I have a schema "UnitTest1.zap"
	When I try to generate code from that schema
	Then code generation must succeed

@Coverage
Scenario: Missing frontend
	Given zap.exe is not installed on my system
	And I have a schema "UnitTest1.zap"
	When I try to generate code from that schema
	Then the invocation must fail

@Coverage
Scenario: Schema without ID
	Given zap.exe is installed on my system
	And I have a schema "Empty1.zap"
	When I try to generate code from that schema
	Then the invocation must fail
	And the reason must be bad input
	And the error output must contain "File does not declare an ID"

@Coverage
Scenario: Multiple errors
	Given zap.exe is installed on my system
	And I have a schema "invalid.zap"
	When I try to generate code from that schema
	Then the invocation must fail
	And the reason must be bad input
	And the error output must contain multiple messages

@Coverage
Scenario Outline: Valid generator output
	Given I have a binary code generator request <bin>
	And I enable generation of nullable reference types according to <nullablegen>
	And I enable the compiler support of nullable reference types according to <nullablesupp>
	When I invoke zapc-csharp
	Then the invocation must succeed and attempting to compile the generated code gives <outcome>

Examples:
    | bin                         | nullablegen | nullablesupp | outcome  |
    | test.zap.bin              | false       | false        | success  |
    | test.zap.bin              | true        | false        | errors   |
    | test.zap.bin              | false       | true         | warnings |
    | test.zap.bin              | true        | true         | success  |
    | Issue19.zap.bin           | false       | false        | success  |
    | Issue21.zap.bin           | false       | false        | success  |
    | Issue22.zap.bin           | false       | false        | success  |
    | NullableDisable.zap.bin   | true        | false        | success  |
    | NullableDisable.zap.bin   | true        | true         | warnings |
    | NullableEnable.zap.bin    | false       | true         | success  |
	| NullableEnable.zap.bin    | false       | false        | errors   |
	| NullableDisable2.zap.bin  | false       | false        | errors   |
    | NullableDisable2.zap.bin  | false       | true         | success  |
    | NullableEnable2.zap.bin   | false       | false        | errors   |
	| NullableEnable2.zap.bin   | false       | true         | success  |
	| rpc-csharp.zap.bin        | true        | true         | warnings |
	| schema-csharp.zap.bin     | false       | false        | success  |