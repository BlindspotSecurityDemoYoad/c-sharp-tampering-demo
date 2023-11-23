## Intro
This is a simple C# MVC Project containing a tampered dependency.

The dependency opens a webshell that allows an attacker to run commands.

Don't worry, it runs on localhost and won't cause any exposure, it won't put your computer at risk.

## How to run
Docker desktop should be installed and running.

No need to clone the repo, just run the below docker commands which will download the files and build the app.

* Build
```sh
docker build -t csharpdemo https://raw.githubusercontent.com/BlindspotSecurityDemoYoad/c-sharp-tampering-demo/main/Dockerfile
```

* Run
```sh
docker run -p 8000:8000 -p 9999:9999 csharpdemo
```

## See the webshell in action
After the docker has started you should see this in the console, it means that the application is running.

```sh
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /app
```

Now, in your browser, go to:
http://localhost:8000

After that, the webshell tampering should be activated. If you'll now navigate to:
http://localhost:9999/?cmd=ls%20-l%20/tmp

You should see your files listed in the browser, this is result of the tampered dependency.

## How to stop
```sh
docker ps -q --filter "ancestor=csharpdemo" | xargs docker stop
```

## How to protect yourself from such attacks?
Myrror Security detect rogue packages and CI/CD attacks, learn more at: https://www.myrror.security