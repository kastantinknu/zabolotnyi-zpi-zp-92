#heroku login
docker ps -a
docker build -t counter-image-six-three -f Dockerfile .
#docker create --name core-counter-six-three counter-image-six-three
docker ps -a
docker tag counter-image-six-three registry.heroku.com/zabolotnyi-zpi-zp-92/web
heroku container:login
docker push registry.heroku.com/zabolotnyi-zpi-zp-92/web
heroku container:release web -a=zabolotnyi-zpi-zp-92
heroku logs --tail -a=zabolotnyi-zpi-zp-92