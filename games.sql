SELECT * FROM sql11421518.Games;
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('15', '2020-12-31', '3', '2', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('2', '2020-12-31', '1', '2', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('3', '2020-12-01', '3', '1', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('4', '2020-12-31', '3', '4', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('5', '2020-12-02', '1', '2', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('6', '2020-12-31', '4', '2', '1:1');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('7', '2020-10-31', '3', '2', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('8', '2020-12-31', '3', '2', '1:3');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('9', '2020-12-31', '4', '2', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('10', '2020-12-31', '3', '1', '1:0');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('11', '2020-12-31', '3', '2', '1:4');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('12', '2020-01-31', '1', '2', '7:10');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('13', '2020-05-31', '3', '2', '1:5');
INSERT INTO `sql11421518`.`Games` (`Id`, `Data`, `FirstTeamId`, `SecondTeamId`, `Score`) VALUES ('14', '2020-12-31', '3', '4', '1:0');

SELECT * FROM sql11421518.Players;
INSERT INTO Players (Id, Name, Position, RedCard)
VALUES (1, 'Raul', 'Goalkeeper', 0);
VALUES (2, 'Pedro', 'Defender', 0);
VALUES (3, 'Don', 'Midfielder', 0);
VALUES (4, 'Dominic', 'Forward', 0);
VALUES (5, 'Pablo', 'Forward', 0);

ALTER TABLE Players ADD CONSTRAINT fk_teamid FOREIGN KEY (TeamName) REFERENCES Teams(Id);
ALTER TABLE Games ADD CONSTRAINT fk_firstteamid FOREIGN KEY (FirstTeamId) REFERENCES Teams(Id);
ALTER TABLE Games ADD CONSTRAINT fk_secondteamid FOREIGN KEY (SecondTeamId) REFERENCES Teams(Id);


ALTER TABLE Players DROP   FOREIGN KEY fk_teamname;
