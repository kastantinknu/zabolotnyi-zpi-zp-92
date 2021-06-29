heroku login
docker ps -a
docker build -t counter-image-six-two -f Dockerfile .
docker create --name core-counter-six-two counter-image-six-two
docker ps -a
docker tag counter-image-six-two registry.heroku.com/zabolotnyi-zpi-zp-92/web
heroku container:login
docker push registry.heroku.com/zabolotnyi-zpi-zp-92/web
heroku container:release web -a=zabolotnyi-zpi-zp-92
heroku logs --tail -a=zabolotnyi-zpi-zp-92