# .NET API demo for using OAuth 2.0

## Configure redirect URL to use in Goggle OAuth 2.0 Playground

### Step 1: Go to Google Cloud Console
Visit: https://console.cloud.google.com/apis/credentials

### Step 2: Find Your OAuth Client

Click on your OAuth 2.0 Client ID
Look for the "Authorized redirect URIs" section

### Step 3: Add the Correct Redirect URI

For OAuth 2.0 Playground:
https://developers.google.com/oauthplayground

### Step 4: Save and Wait

Click "Save"
Wait 5-10 minutes for changes to propagate

## Getting Google OAuth Token for API Testing using OAuth 2.0 Playground

Follow these steps to obtain a JWT ID token for testing your API:

### Step 1: Access OAuth Playground
* Go to: https://developers.google.com/oauthplayground/

### Step 2: Configure Your Credentials
* Click the **Settings** (gear icon) in the top right
* Check **"Use your own OAuth credentials"**
* Enter your **OAuth Client ID**
* Enter your **OAuth Client Secret**

### Step 3: Select API Scopes
* In the left panel under **Step 1 - Select & authorize APIs**:
  * Find **"Google OAuth2 API v2"**
  * Check these scopes:
    * `https://www.googleapis.com/auth/userinfo.email`
    * `https://www.googleapis.com/auth/userinfo.profile`
    * `openid`

### Step 4: Authorize
* Click **"Authorize APIs"** button
* Sign in with your Google account
* Grant permissions when prompted

### Step 5: Get Tokens
* Click **"Exchange authorization code for tokens"**

### Step 6: Copy the ID Token
* Copy the **`id_token`** (this is the JWT your API needs!)
  * It will look like: `eyJhbGciOiJSUzI1NiIsImtpZCI6Ij...` (very long with 2 dots)
  * **NOT** the `access_token` (which is shorter and has only 1 dot)

### Using the Token

Test your API with the ID token:

```bash
curl -H "Authorization: Bearer YOUR_ID_TOKEN_HERE" \
     https://localhost:5001/api/user/profile
```

## Notes

* The ID token is valid for **1 hour**
* The token remains valid even if you close the OAuth Playground tab
* The token has 3 parts separated by dots: `header.payload.signature`
* You can decode the token at https://jwt.io to view its contents