Feature: Move Rover
	As a new Mars Rover landed by NASA
	I want to be able to move around the planet Mars
	In order to accomplish my mission

@MoveRover
Scenario: Move Rover Forward, Forward, Turn Right, and Forward
	Given The rover is located at "0,0,N"
	And is on a "100x100" grid
	When the rover is given the command "FFRFF"
	Then the rover is at "2,2,E".