start:
	docker-compose \
		--project-directory=${PWD} \
		--project-name=rider_issue \
		-f docker-compose.yml \
		up --build -d

stop:
	docker-compose \
		--project-directory=${PWD} \
		--project-name=rider_issue \
		-f docker-compose.yml \
		down
