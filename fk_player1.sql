ALTER TABLE Players ADD CONSTRAINT fk_teamid FOREIGN KEY (TeamName) REFERENCES Teams(Id);